using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace AVRO_CONSTRUKTİON_MMC.Models
{
    public class ContactMessage:BaseEntity
    {
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(15)]

        public string Phone { get; set; }
        [MaxLength(500)]

        public string Message { get; set; }
        public bool? IsReplied { get; set; }
    }
}
