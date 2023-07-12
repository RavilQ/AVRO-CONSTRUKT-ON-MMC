using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.ViewModel
{
    public class ContactPostViewModel
    {
        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        [MaxLength(30, ErrorMessage = "30 hərfdən ibarət olmalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        [MaxLength(50, ErrorMessage = "50 hərfdən ibarət olmalıdır.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        [MaxLength(15, ErrorMessage = "15 hərfdən ibarət olmalıdır.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        [MaxLength(500, ErrorMessage = "500 hərfdən ibarət olmalıdır.")]
        public string Message { get; set; }
    }
}
