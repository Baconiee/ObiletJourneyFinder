namespace ObiletJourneyFinder.Application.Interfaces;

public interface ISessionService
{
    public Task<(string sessionId, string deviceId)> GetSessionAsync();
}
