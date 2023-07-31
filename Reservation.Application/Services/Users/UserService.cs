using Microsoft.AspNetCore.Identity;
using Reservation.Application.Contract.Dtos.Users;
using Reservation.Application.Contract.IServices.Users;
using Reservation.Infrastructure.Contexts;
using Reservation.Model.IdentityModels;

namespace Reservation.Application.Services.Users
{
    public class UserService : IUserService
    {
        private readonly ITokenHandler tokenHandler;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPasswordHasher<ApplicationUser> passwordHasher;
        public UserService(ITokenHandler tokenHandler, UserManager<ApplicationUser> userManager, IPasswordHasher<ApplicationUser> passwordHasher)
        {
            this.tokenHandler = tokenHandler;
            this.userManager = userManager;
            this.passwordHasher = passwordHasher;
        }

        public string Login(LoginDto dto)
        {
            var user = userManager.FindByNameAsync(dto.UserName).GetAwaiter().GetResult();

            if (userManager.CheckPasswordAsync(user, dto.Password).GetAwaiter().GetResult())
            {
                var roles = userManager.GetRolesAsync(user).
                    GetAwaiter().GetResult().ToArray();
                return tokenHandler.GenerateToken(user.Id, roles);
            }

            return user.Id;
        }

        public bool Register(RegisterDto dto)
        {
            var user = new ApplicationUser(dto.UserName);
            
            user.PasswordHash = passwordHasher.HashPassword(user, dto.Password);
            var userRole = new ApplicationUserRole()
            {
                RoleId = RoleSeedData.RoleId,
                UserId = user.Id
            };

            user.ApplicationUserRoles.Add(userRole);
            var SavedUser = userManager.CreateAsync(user).GetAwaiter().GetResult();

            return SavedUser != null;
        }
    }
}
