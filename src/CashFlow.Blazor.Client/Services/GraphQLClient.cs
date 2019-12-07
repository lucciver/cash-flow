using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace CashFlow.Blazor.Client.Services
{
    public sealed class GraphQLClient : IGraphQLClient
    {
        private readonly HttpClient _client;

        public GraphQLClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<T> Query<T>(string query, string fieldName)
        {
            var request = new GraphQLRequest
            {
                Query = query,
            };

            GraphQLResponse<T> response = await _client.PostJsonAsync<GraphQLResponse<T>>(Constants.ApiEndpoint, request);

            return response.Data[fieldName];
        }

        private sealed class GraphQLRequest
        {
            public string OperationName { get; set; }

            public string Query { get; set; }

            public string Mutation { get; set; }
        }

        private sealed class GraphQLResponse<T>
        {
            public Dictionary<string, T> Data { get; set; }
        }
    }

    public interface IGraphQLClient
    {
        Task<T> Query<T>(string query, string fieldName);
    }
}
