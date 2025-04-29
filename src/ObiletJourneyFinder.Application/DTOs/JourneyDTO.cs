namespace ObiletJourneyFinder.Application.DTOs;

// Represents a bus journey for data transfer between layers
// used for displaying journey details.
public class JourneyDTO
{
    public int Id { get; set; }
    public BusLocationDTO Origin { get; set; }
    public BusLocationDTO Destination { get; set; }
    public string OriginTerminalName { get; set; }
    public string DestinationTerminalName { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public decimal Price { get; set; }
}
