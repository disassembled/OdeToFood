namespace OdeToFood.Models
{
    public class RestaurantEditModel
    {
        public int Id { get; set; } // TODO: prevent build requirement for this unrequired field
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
