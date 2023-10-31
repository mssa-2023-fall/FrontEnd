using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

public class MaintenanceMiddleware
{
    private readonly RequestDelegate _next;
    private readonly TimeSpan maintenanceStartTime;
    private readonly TimeSpan maintenanceDuration;

    public MaintenanceMiddleware(RequestDelegate next)
    {
        _next = next;
        // Set the maintenance start time to 2 AM on Sundays
        maintenanceStartTime = new TimeSpan(2, 0, 0);
        maintenanceDuration = TimeSpan.FromHours(2);
    }

    public async Task Invoke(HttpContext context)
    {
        var now = DateTime.UtcNow;

        //maintenance endtime from start by adding two hours
        var maintenanceEndTime = maintenanceStartTime.Add(maintenanceDuration);
        // Check if it's Sunday and the current time is past 2 AM
        if (now.DayOfWeek == DayOfWeek.Sunday && now.TimeOfDay >= maintenanceStartTime && now.TimeOfDay < maintenanceEndTime)
        {
            // Redirect to the maintenance page
            context.Response.Redirect("/maintenance");
        }
        else
        {
            // Continue processing the request
            await _next(context);
        }
    }
}

public static class MaintenanceMiddlewareExtensions
{
    public static IApplicationBuilder UseMaintenanceMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<MaintenanceMiddleware>();
    }
}
