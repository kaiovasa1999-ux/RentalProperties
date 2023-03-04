namespace RentalProperties.Data.Models
{
    public class Broker
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string UserId { get; set; }

        public ICollection<Property> Properties { get; set; }= new List<Property>();
    }
}