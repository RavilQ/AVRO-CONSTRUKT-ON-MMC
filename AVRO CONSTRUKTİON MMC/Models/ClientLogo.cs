using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Models
{
    public class ClientLogo : BaseEntity
    {
        [MaxLength(200)]
        public string Image { get; set; }
      
    }
}
