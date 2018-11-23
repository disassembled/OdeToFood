using System.ComponentModel.DataAnnotations;
using OdeToFood.Services;

namespace OdeToFood.Models
{
    public class RestaurantEditModel
    {
        public int Id { get; set; } // TODO: prevent build requirement for this unrequired field

        [Required, MaxLength(80)]
        [Display(Name="Restaurant Name")]
        public string Name { get; set; }

        [RequiredEnum(ErrorMessage = "The Cuisine type is required.")]
        public CuisineType Cuisine { get; set; }
    }
}
