namespace TaxiApp_Data.Models
{
    internal class Drive : Entity
    {
        public int DriverId { get; set; }
        public int CustomerId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Drive()
        {

        }

        public Drive(int driverId, int customerId, double price, string description, string image)
        {
            DriverId = driverId;
            CustomerId = customerId;
            Price = price;
            Description = description;
            Image = image;
        }
    }
}
