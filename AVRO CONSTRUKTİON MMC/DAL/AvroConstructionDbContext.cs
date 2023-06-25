using Microsoft.EntityFrameworkCore;

namespace AVRO_CONSTRUKTİON_MMC.DAL
{
    public class AvroConstructionDbContext:DbContext
    {
        public AvroConstructionDbContext(DbContextOptions<AvroConstructionDbContext> opt): base(opt)
        {

        }
    }
}
