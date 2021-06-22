using System.Collections.Generic;
using Mapster.Issues.Domain.Lookup;
using Mapster.Issues.Domain.Organizations;

namespace Mapster.Issues.Domain.People
{
    public record Me
    {
        public string Name { get; init; } = null!;

        public Province Location { get; init; } = null!;

        public Company Job { get; init; } = null!;

        public ICollection<Friend>? Friends { get; init; }
    }
}
