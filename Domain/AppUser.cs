namespace Domain
{
    public class AppUser : Microsoft.AspNetCore.Identity.IdentityUser<int>
    {

        public virtual ICollection<Car>? Cars { get; set; }

        public virtual ICollection<Role>? Roles { get; set; }


    }
}
