using System.ComponentModel.DataAnnotations;
using OdeToFood.Services;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required, MaxLength(80)]
        [Display(Name="Restaurant Name")]
        public string Name { get; set; }

        [RequiredEnum(ErrorMessage = "The Cuisine type is required.")]
        public CuisineType Cuisine { get; set; }
    }
}
