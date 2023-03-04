namespace RentalProperties.Data.Models
{
    public class Categpry
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Property> Properties { get; set; } = new List<Property>();
    }
}
