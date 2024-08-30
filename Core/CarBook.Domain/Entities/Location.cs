using System.ComponentModel.DataAnnotations;
namespace CarBook.Domain.Entities
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        public string Name { get; set; }
    }
}
