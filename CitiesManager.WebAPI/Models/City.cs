using System.ComponentModel.DataAnnotations;

namespace CitiesManager.WebAPI.Models
{
    public class City
    {
        [Key]
        public Guid CityID { get; set; } //Essential model properties
        public string? CityName { get; set; }
         
    }
}
