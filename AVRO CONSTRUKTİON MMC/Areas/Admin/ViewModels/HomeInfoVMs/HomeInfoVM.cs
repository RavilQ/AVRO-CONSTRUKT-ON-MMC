namespace AVRO_CONSTRUKTİON_MMC.Areas.Admin.ViewModels.HomeInfoVMs
{
    public class HomeInfoVM
    {
        public string Title { get; set; }
        public IFormFile? RightImage { get; set; }
        public IFormFile? LeftImage { get; set; }
        public string Description { get; set; }
        public string BtnText { get; set; }
        public string BtnLink { get; set; }

        public IDictionary<string, string?>? Settings { get; set; }
    }
}
