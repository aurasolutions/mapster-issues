namespace Mapster.Issues.Domain.Lookup
{
    public record Province
    {
        public string Name { get; init; } = null!;

        public string Abbreviation { get; init; } = null!;
    }
}
