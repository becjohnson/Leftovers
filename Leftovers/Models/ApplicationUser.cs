using Microsoft.AspNetCore.Identity;

namespace Leftovers.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Points { get; set; }
    }
}
