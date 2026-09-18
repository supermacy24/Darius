namespace Darius.Api.Features.Clock;

public class ClockService
{
    public ClockResponse GetCurrentTime()
    {
        return new ClockResponse(DateTimeOffset.UtcNow);
    }
}