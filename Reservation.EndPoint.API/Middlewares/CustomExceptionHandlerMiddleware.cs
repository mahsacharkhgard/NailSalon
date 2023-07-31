using Reservation.EndPoint.API.Filters;
using System.Net;
using ApplicationException = Reservation.EndPoint.API.Exceptions.ApplicationException;

namespace Reservation.EndPoint.API.Middlewares
{
    public class CustomExceptionHandlerMiddleware
    {
        public CustomExceptionHandlerMiddleware(RequestDelegate next)
        {
            Next = next;
        }

        public RequestDelegate Next { get; set; }


        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await Next(context);
            }
            catch (ApplicationException ex)
            {
                if (ex.IsConfidentiality == false)
                {
                    var res = new MyResponse(ex.Message);
                    context.Response.StatusCode = (int)ex.StatusCode;
                    await context.Response.WriteAsJsonAsync(res);
                }
                else
                {
                    await UnHandleError(context);
                }

            }
            catch (Exception ex)
            {
                await UnHandleError(context);
            }
        }

        private static async Task UnHandleError(HttpContext context)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            await context.Response.WriteAsJsonAsync("InternalServerError");
        }
    }
}
