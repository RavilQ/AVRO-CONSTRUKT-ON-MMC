using Microsoft.AspNetCore.Identity;

namespace AVRO_CONSTRUKTİON_MMC.Models
{
    public class AppUser:IdentityUser
    {
        public bool IsDefaultPassword { get; set; }
    }
}
