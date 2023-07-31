using Shop.EndPoint.API;
using System.Net;

namespace Reservation.EndPoint.API.Exceptions
{
    public class DontAllowAccessException : ApplicationException
    {
        public DontAllowAccessException() : base(Resource.ApplicationExceptionMessage, HttpStatusCode.Unauthorized, false)
        {
        }
    }
}
