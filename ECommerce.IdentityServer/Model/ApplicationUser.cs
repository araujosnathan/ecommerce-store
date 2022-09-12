using Microsoft.AspNetCore.Identity;

namespace ECommerce.IdentityServer
{
    public class ApplicationUser : IdentityUser
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
    }
}

