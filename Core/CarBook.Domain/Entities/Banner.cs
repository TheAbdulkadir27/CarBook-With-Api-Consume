using System.ComponentModel.DataAnnotations;

namespace CarBook.Domain.Entities
{
    public class Banner
    {
        [Key]
        public int BannerID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoDescription { get; set; }
        public string VideoUrl { get; set; }
    }
}
