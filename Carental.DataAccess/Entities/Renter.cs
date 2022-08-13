﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carental.DataAccess.Entities
{
    public class Renter
    {
        [Key]
        
        public Guid Id { get; set; }
        //[Required(ErrorMessage = "Name is required")]
        //[StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string? Name { get; set; }
    }
}
