
using Microsoft.AspNetCore.Identity;

namespace Reservation.Model.IdentityModels
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
        {

        }

        public ApplicationRole(string roleName) : base(roleName)
        {
            ApplicationUserRoles = new HashSet<ApplicationUserRole>();
        }
        public ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; }
    }
}
