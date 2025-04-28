namespace ObiletJourneyFinder.Domain.Entities;

/// <summary>
/// Represents a bus journey with Origins, destinations, and additional details.
/// </summary>
public class Journey
{
    public int Id { get; private set; }
    public BusLocation Origin { get; private set; }
    public BusLocation Destination { get; private set; }
    public string OriginTerminalName { get; private set; }
    public string DestinationTerminalName { get; private set; }
    public DateTime DepartureTime { get; private set; }
    public DateTime ArrivalTime { get; private set; }
    public decimal Price { get; private set; }

    private Journey() { }

    public Journey(int id, BusLocation origin, BusLocation destination, string originTerminalName, string destinationTerminalName,
                   DateTime departureTime, DateTime arrivalTime, decimal price,
                   )
    {
        Id = id;
        Origin = origin ?? throw new ArgumentNullException(nameof(origin));
        Destination = destination ?? throw new ArgumentNullException(nameof(destination));
        OriginTerminalName = originTerminalName ?? throw new ArgumentNullException(nameof(originTerminalName));
        DestinationTerminalName = destinationTerminalName ?? throw new ArgumentNullException(nameof(destinationTerminalName));
        DepartureTime = departureTime;
        ArrivalTime = arrivalTime;
        Price = price;

        ValidateLocations();
        ValidateTimes();
    }

    public void ValidateLocations()
    {
        if (Origin.Id == Destination.Id)
            throw new InvalidOperationException("Origin and destination cannot be the same.");
    }

    public void ValidateTimes()
    {
        if (DepartureTime.Date < DateTime.UtcNow.Date)
            throw new InvalidOperationException("Departure date cannot be in the past.");

        if (ArrivalTime <= DepartureTime)
            throw new InvalidOperationException("Arrival time must be after departure time.");
    }
}