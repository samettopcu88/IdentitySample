using Microsoft.AspNetCore.Identity;

namespace IdentitySample.Models.Authentication
{
    public class AppUserClaim : IdentityUserClaim<int>
    {
        public bool LocalCLaim { get; set; }
    }
}
