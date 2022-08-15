namespace Carental.DataAccess.Entities
{
    public class Car
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public int ModelYear { get; set; }
        public string? Color { get; set; }
        public int Capacity { get; set; }
        public string? PlateNumber { get; set; }
        public Guid RenterId { get; set; }
        public decimal PricePerMinute { get; set; }
        public decimal PricePerKilometer { get; set; }
        public decimal ParkedPricePerMinute { get; set; }
        public Location? Location { get; set; }

        public virtual Renter? Renter { get; set; }
    }
}
