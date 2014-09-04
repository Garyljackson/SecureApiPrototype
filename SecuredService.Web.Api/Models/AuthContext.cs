using Microsoft.AspNet.Identity.EntityFramework;

namespace SecuredService.Web.Api.Models
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {
        }
    }
}
