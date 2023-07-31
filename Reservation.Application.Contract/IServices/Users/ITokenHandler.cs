using System.Security.Claims;

namespace Reservation.Application.Contract.IServices.Users
{
    public interface ITokenHandler
    {
        string GenerateToken(string userId, params string[] roles);

        List<Claim> ValidateToken(string token);
    }
}
