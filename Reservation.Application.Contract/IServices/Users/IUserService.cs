using Reservation.Application.Contract.Dtos.Users;

namespace Reservation.Application.Contract.IServices.Users
{
    public interface IUserService
    {
        string Login(LoginDto dto);
        bool Register(RegisterDto dto);
    }
}
