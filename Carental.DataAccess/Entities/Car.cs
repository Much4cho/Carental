namespace Carental.DataAccess.Entities
{
    public class Car
    {
        public Guid Id { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public Guid RenterId { get; set; }
        public decimal PricePerMinute { get; set; }
        public decimal PricePerKilometer { get; set; }
        public decimal ParkedPricePerMinute { get; set; }

        public virtual Renter? Renter { get; set; }
    }
}
