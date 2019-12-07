using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashFlow.Blazor.Client.Models
{
    public sealed class Supplier
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ContactInfo { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset? DateModified { get; set; }
    }
}
