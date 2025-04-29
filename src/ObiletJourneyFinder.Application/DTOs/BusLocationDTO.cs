namespace ObiletJourneyFinder.Application.DTOs;

// Represents a bus location for data transfer between layers
// including sorting information.
public class BusLocationDTO
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Gets or sets the rank of the bus location, used for sorting default values in the UI.
    public int Rank { get; set; }
}
