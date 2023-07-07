using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.AccountVMs
{
    public class LoginVM
    {
        [Required]
        [MaxLength(20)]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [MinLength(5)]
        [MaxLength(20)]

        public string Password { get; set; }
    }
}
