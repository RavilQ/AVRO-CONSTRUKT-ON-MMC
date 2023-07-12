using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Models
{
    public class ContactMessageReply:BaseEntity
    {
        public ContactMessage ContactMessage { get; set; }
        public int ContactMessageId { get; set; }
        [MaxLength(50)]
        public string Message { get; set; }
        [MaxLength(500)]
        public string Subject { get; set; }
    }
}
