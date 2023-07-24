using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces;
using AVRO_CONSTRUKTİON_MMC.Models;

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
        public ICollection<Project> GetProjects()
        {
            return _context.Projects.Where(x=> x.IsFeatured).Take(5).ToList();
        }
    }
}
