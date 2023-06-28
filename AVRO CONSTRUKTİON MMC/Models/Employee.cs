namespace AVRO_CONSTRUKTİON_MMC.Models
{
    public class Employee:BaseEntity
    {
        public string Fullname { get; set; }
        public int JobId { get; set; }
        public string Image { get; set; }

        public Job Job { get; set; }
    }
}
