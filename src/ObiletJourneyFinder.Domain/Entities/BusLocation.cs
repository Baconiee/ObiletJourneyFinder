namespace ObiletJourneyFinder.Domain.Entities;

/// <summary>
/// Represents a bus location with required properties.
/// </summary>
public class BusLocation
{
	public int Id { get; private set; }
    public string Name { get; private set; }

    private BusLocation() { }

    public BusLocation(int id, string name)
    {
        Id = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }
}
