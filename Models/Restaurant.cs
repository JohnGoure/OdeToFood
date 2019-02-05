namespace OdeToFood.Models {
    public class Restaurant {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}