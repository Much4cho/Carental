namespace Carental.DataAccess.Entities
{
    public class Rental
    {
        public Guid Id { get; set; }
        public Guid CarId { get; set; }
        //public Guid CustomerId { get; set; }

        //public DateTime RentedOnUtc { get; set; }
        //public DateTime ReturnedOnUtc { get; set; }
        //public decimal TotalPrice { get; set; }


        public DateTime ReservedOnUtc { get; set; }
        public DateTime? RentedOnUtc { get; set; }
        public DateTime? ReturnedOnUtc { get; set; }
        public DateTime? ClosedOnUtc { get; set; }
        public decimal PricePerMinute { get; set; }
        public decimal PricePerKilometer { get; set; }
        public decimal ParkedPricePerMinute { get; set; }
        public TimeSpan? TotalTimeDriving { get; set; } = TimeSpan.Zero;
        public TimeSpan? TotalTimeParked { get; set; } = TimeSpan.Zero;
        public decimal TotalKmMade { get; set; }
        public Location? LastLocation { get; set; }
        public int Status { get; set; }
        public string? Remarks { get; set; }
        public virtual Car? Car { get; set; }
    }
}
