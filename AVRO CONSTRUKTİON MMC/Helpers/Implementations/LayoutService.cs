using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces;

namespace AVRO_CONSTRUKTİON_MMC.Helpers.Implementations
{
    public class LayoutService : ILayoutService
    {
        private readonly AvroConstructionDbContext _context;

        public LayoutService(AvroConstructionDbContext context)
        {
            _context = context;
        }

        public IDictionary<string, string?> GetSettingsDictionary()
        {
            return _context.Settings.ToDictionary(x=> x.Key, y=>y.Value); 
        }
    }
}
