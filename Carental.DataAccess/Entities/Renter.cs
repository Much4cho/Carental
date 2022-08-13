using System.Collections.Generic;

namespace Carental.DataAccess.Entities
{
    public class Renter
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public virtual List<Car>? Cars { get; internal set; }
    }
}
