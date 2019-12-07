using System;

namespace CashFlow.Blazor.Client.Models
{
    public sealed class Account
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset? DateModified { get; set; }
    }
}
