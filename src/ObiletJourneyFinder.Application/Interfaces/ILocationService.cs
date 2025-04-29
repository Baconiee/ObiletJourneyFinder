using System.Collections.Generic;
using ObiletJourneyFinder.Application.DTOs;


namespace ObiletJourneyFinder.Application.Interfaces;

public interface ILocationService
{
    Task<IEnumerable<BusLocationDTO>> GetBusLocationsAsync((string sessionId, string deviceId) session);
    Task<IEnumerable<BusLocationDTO>> SearchLocationsAsync((string sessionId, string deviceId) session, string keyword);
}
