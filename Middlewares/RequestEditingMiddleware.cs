namespace UdemyAspNetCoreMvc.Middlewares
{
    public class RequestEditingMiddleware
    {
        private RequestDelegate _requestDelegate;

        public RequestEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            //innova.com.tr/yusuf
            if (context.Request.Path.ToString() == "/yusuf")
                await context.Response.WriteAsync("Hosgeldin Yusuf");
            else
                await _requestDelegate.Invoke(context);
        }
    }
}
