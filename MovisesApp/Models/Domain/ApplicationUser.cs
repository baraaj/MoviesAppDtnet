using Microsoft.AspNetCore.Identity;

namespace MovisesApp.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name{ get; set; }
    }
}
