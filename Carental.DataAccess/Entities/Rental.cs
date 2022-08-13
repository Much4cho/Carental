namespace Carental.DataAccess.Entities
{
    public class Rental
    {
        public Guid Id { get; set; }
        public Guid CarId { get; set; }
        //public Guid CustomerId { get; set; }

        public DateTime RentedOnUtc { get; set; }
        public DateTime ReturnedOnUtc { get; set; }
        public decimal TotalPrice { get; set; }
        public int Status { get; set; }
        public string? Remarks { get; set; }
        public virtual Car? Car { get; set; }
    }
}
