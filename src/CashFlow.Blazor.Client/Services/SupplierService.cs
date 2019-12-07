using System.Threading.Tasks;
using CashFlow.Blazor.Client.Models;

namespace CashFlow.Blazor.Client.Services
{
    public sealed class SupplierService : ISupplierService
    {
        private readonly IGraphQLClient _client;

        public SupplierService(IGraphQLClient client)
        {
            _client = client;
        }

        public async Task<Supplier[]> GetSuppliers()
        {
            var query = @"
                query getSuppliers {
                    suppliers {
                        id
                        name
                        contactInfo
                        dateCreated
                        dateModified
                    }
                }";

            return await _client.Query<Supplier[]>(query, "suppliers");
        }
    }

    public interface ISupplierService
    {
        Task<Supplier[]> GetSuppliers();
    }
}
