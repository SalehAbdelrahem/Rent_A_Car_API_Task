using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace DAL.Models
{
    public class AppUser : IdentityUser<int>
    {
        
        public virtual ICollection<Car>? Cars { get; set; }

        public virtual ICollection<Role>? Roles { get; set; }


    }
}
