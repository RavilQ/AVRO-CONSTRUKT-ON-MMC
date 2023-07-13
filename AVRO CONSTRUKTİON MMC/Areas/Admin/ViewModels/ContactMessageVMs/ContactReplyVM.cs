using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.ContactMessageVMs
{
    public class ContactReplyVM
    {
        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        [MaxLength(50, ErrorMessage ="50 hərfdən ibarət olmalıdır")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        [MaxLength (500, ErrorMessage = "50 hərfdən ibarət olmalıdır")]
        public string Message { get; set; }
    }
}
