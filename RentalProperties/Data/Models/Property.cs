namespace RentalProperties.Data.Models
{
    public class Property
    {
        public int Id { get; set; }

        public string? Location { get; set; }

        public int CategoryID { get; set; }

        public Categpry Categpry { get; set; }

        public string ImageUrL { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public PropertyType PropertyType { get; set; }

        public int BrokerId { get; set; }

        public Broker Broker { get; set; }
    }
}
