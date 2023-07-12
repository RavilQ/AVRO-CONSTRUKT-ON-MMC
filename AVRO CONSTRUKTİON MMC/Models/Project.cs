using System.ComponentModel.DataAnnotations;

namespace AVRO_CONSTRUKTİON_MMC.Models
{
    public class Project:BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(5000)]
        public string Description { get; set; }
        [MaxLength(200)] 
        
        public string Image { get; set; }
        
    }
}
