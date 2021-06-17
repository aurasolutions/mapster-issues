using Mapster.Issues.Domain.Lookup;

namespace Mapster.Issues.Domain.Organizations
{
    public record Company
    {
        public string Name { get; init; } = null!;

        public Province? Province { get; init; }
    }
}
