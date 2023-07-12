using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace AVRO_CONSTRUKTİON_MMC.Models
{
    public class ContactMessage:BaseEntity
    {
        public ContactMessage()
        {
            CreatedAt = DateTime.UtcNow.AddHours(4);
        }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(15)]

        public string Phone { get; set; }
        [MaxLength(500)]

        public string Message { get; set; }
        public bool? IsReplied { get; set; }
        public DateTime CreatedAt { get; set; }

        public ContactMessageReply? ContactMessageRepy { get; set; }
    }
}
