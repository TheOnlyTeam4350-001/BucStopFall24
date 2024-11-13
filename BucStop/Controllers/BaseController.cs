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

    public async Task InvokeAsync(HttpContext context)
    {
        var path = context.Request.Path.ToString().ToLower();

        if (path == "/" || path == "/home/index")
        {
            // Increment the visit count when someone visits the page index
            _visitCountManager.IncrementVisitCount();
        }

        // Retrieve the latest visit count after incremementing and set it in HttpContext.Items
        context.Items["VisitCount"] = _visitCountManager.GetVisitCounts();

        await _next(context);
    }
}
