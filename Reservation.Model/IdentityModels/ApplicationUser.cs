


using Microsoft.AspNetCore.Identity;

namespace Reservation.Model.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser(string userName) : base(userName)
        {
            ApplicationUserRoles = new HashSet<ApplicationUserRole>();
        }

        //  public IdentityUserLogin<string> IdentityUserLogin { get; set; }

        public ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; }
    }
}
