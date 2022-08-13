namespace Carental.BusinessLogic.Models.Rental
{
    public class StartRentalCommand
    {
        public Guid CarId { get; set; }
        //public Guid CustomerId { get; set; }
        public string? Remarks { get; set; }
    }
}
