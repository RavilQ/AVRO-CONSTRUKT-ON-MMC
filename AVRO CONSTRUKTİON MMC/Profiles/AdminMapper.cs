using AutoMapper;
using AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels;
using AVRO_CONSTRUKTİON_MMC.Models;
using AVRO_CONSTRUKTİON_MMC.ViewModel;

namespace AVRO_CONSTRUKTİON_MMC.Profiles
{
    public class AdminMapper :Profile
    {
        public AdminMapper()
        {
            CreateMap<Slider, SliderPutVM>();
            CreateMap<ContactPostViewModel, ContactMessage>();
        }
    }
}
