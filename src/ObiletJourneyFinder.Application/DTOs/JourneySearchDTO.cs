namespace ObiletJourneyFinder.Application.DTOs;

// Represents the search criteria for a bus journey
// including origin, destination, and departure date.
public class JourneySearchDTO
{
    public int OriginId { get; private set; }
    public int DestinationId { get; private set; }
    public DateTime DepartureDate { get; private set; }

    private JourneySearchDTO() { }

    public JourneySearchDTO(int originId, int destinationId, DateTime departureDate)
    {
        if (originId <= 0) 
            throw new ArgumentOutOfRangeException(nameof(originId), "Origin ID must be greater than zero.");
        if (destinationId <= 0) 
            throw new ArgumentOutOfRangeException(nameof(destinationId), "Destination ID must be greater than zero.");
        if (DepartureDate.Date < DateTime.UtcNow.Date)
            throw new InvalidOperationException("Departure date cannot be in the past.");
        if (departureDate == DateTime.MinValue)
            throw new ArgumentOutOfRangeException(nameof(departureDate), "Departure date must be specified.");

        OriginId = originId;
        DestinationId = destinationId;
        DepartureDate = departureDate;
    }
}
