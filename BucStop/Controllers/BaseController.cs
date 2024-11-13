using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using BucStop.Services;

public class BaseController
{
    private readonly RequestDelegate _next;
    private readonly VisitCountManager _visitCountManager;

    public BaseController(RequestDelegate next, VisitCountManager visitCountManager)
    {
        _next = next;
        _visitCountManager = visitCountManager;
    }

    //public async Task InvokeAsync(HttpContext context)
    //{
    //    // Increment visit count on each request and retrieve the updated count
    //    int currentVisitCount = _visitCountManager.GetVisitCounts();

    //    // Set the visit count in ViewData for use in _Layout.cshtml
    //    context.Items["VisitCount"] = currentVisitCount;

    //    await _next(context);
    //}

    public async Task InvokeAsync(HttpContext context)
    {
        int currentVisitCount = _visitCountManager.GetVisitCounts();

        // Set the visit count in ViewData for use in _Layout.cshtml
        context.Items["VisitCount"] = currentVisitCount;

        await _next(context);
    }
}
