using Microsoft.AspNetCore.Identity;

namespace RentalProperties.Data.Models
{
    public class User : IdentityUser
    {
        public Broker Broker { get; set; }
    }
}
