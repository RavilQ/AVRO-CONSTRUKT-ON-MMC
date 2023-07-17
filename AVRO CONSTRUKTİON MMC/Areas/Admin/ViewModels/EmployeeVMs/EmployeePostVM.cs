using AVRO_CONSTRUKTİON_MMC.Attributes.ValidationAttributes;
using AVRO_CONSTRUKTİON_MMC.Models;
using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.EmployeeVMs
{
    public class EmployeePostVM
    {
        [MaxLength(30, ErrorMessage = "20 hərfdən artıq olmamalıdır")]
        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        public int JobId { get; set; }


        [AllowedFileTypes("image/jpeg", "image/png")]
        [MaxFileSize(2)]
        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        public IFormFile ImageFile { get; set; }


        [MaxLength(200, ErrorMessage = "200 hərfdən artıq olmamalıdır")]
        public string? LinkedIn { get; set; }


        [MaxLength(200, ErrorMessage = "200 hərfdən artıq olmamalıdır")]
        public string? Email { get; set; }

        public ICollection<Job>? Jobs { get; set; }
    }
}
