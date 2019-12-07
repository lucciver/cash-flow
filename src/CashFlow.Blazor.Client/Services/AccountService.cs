using System.Threading.Tasks;
using CashFlow.Blazor.Client.Models;

namespace CashFlow.Blazor.Client.Services
{
    public sealed class AccountService : IAccountService
    {
        private readonly IGraphQLClient _client;

        public AccountService(IGraphQLClient client)
        {
            _client = client;
        }

        public async Task<Account[]> GetAccounts()
        {
            var query = @"
                query getAccounts {
                    accounts {
                        id
                        name
                        type
                        dateCreated
                        dateModified
                    }
                }";

            return await _client.Query<Account[]>(query, "accounts");
        }
    }

    public interface IAccountService
    {
        Task<Account[]> GetAccounts();
    }
}
