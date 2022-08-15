using Carental.DataAccess.Entities;

namespace Carental.BusinessLogic.Models
{
    public class CarModel
    {
        public Guid Id { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public Guid RenterId { get; set; }
        public decimal PricePerMinute { get; set; }
        public decimal PricePerKilometer { get; set; }
        public decimal ParkedPricePerMinute { get; set; }
        public Location? Location { get; set; }
    }
}