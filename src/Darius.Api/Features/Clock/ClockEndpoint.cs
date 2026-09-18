namespace Darius.Api.Features.Clock;

public static class ClockEndpoint
{
    public static WebApplication MapClockEndpoints(this WebApplication app)
    {
        app.MapGet("/clock", (ClockService service) => service.GetCurrentTime());
        return app;
    }
}