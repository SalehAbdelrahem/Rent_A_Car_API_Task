using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class Role : IdentityRole<int>
    {
        public virtual ICollection<AppUser>? AppUsers { get; set; }
    }
}
