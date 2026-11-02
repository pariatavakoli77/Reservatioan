using System.Diagnostics;

public class RequestTimingMiddleware
{
    private readonly RequestDelegate _next; //نماینده ادامه فیلد در pipeline
    private readonly ILogger<RequestTimingMiddleware> _logger;

    public RequestTimingMiddleware(
        RequestDelegate next,  //RequestDelegate برای سپردن پردازش به مرحله‌ی بعدی
        ILogger<RequestTimingMiddleware> logger)  //ILogger برای ثبت اطلاعات در سیستم Logging.
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context) // وقتی درخواست از این میدلور عبور میکند این متد فراخوانی میشود
    {
        var stopwatch = Stopwatch.StartNew();

        try
        {
            await _next(context);
        }
        finally
        {
            stopwatch.Stop();

            _logger.LogInformation(
                "Request {Method} {Path} completed with status {StatusCode} in {ElapsedMilliseconds} ms",
                context.Request.Method,
                context.Request.Path,
                context.Response.StatusCode,
                stopwatch.ElapsedMilliseconds);
        }
    }
}