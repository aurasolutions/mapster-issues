using System.Collections.Generic;

namespace Mapster.Issues.Domain.Lookup
{
    public record Country
    {
        public string Name { get; init; } = null!;

        public string Abbreviation { get; init; } = null!;

        public ICollection<Province> Provinces { get; init; } = null!;
    }
}
