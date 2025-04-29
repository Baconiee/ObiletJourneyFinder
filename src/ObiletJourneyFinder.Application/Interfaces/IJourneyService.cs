using System.Collections.Generic;
using ObiletJourneyFinder.Application.DTOs;


namespace ObiletJourneyFinder.Application.Interfaces;

public interface IJourneyService
{
	Task<IEnumerable<JourneyDTO>> GetBusJourneysAsync((string sessionId, string deviceId) session, JourneySearchDTO search);
}
