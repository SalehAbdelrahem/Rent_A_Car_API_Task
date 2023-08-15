using Microsoft.AspNetCore.Identity;

namespace DAL.Models
{
    public class Role : IdentityRole<int>
    {
        public virtual ICollection<AppUser>? AppUsers { get; set; }
    }
}
