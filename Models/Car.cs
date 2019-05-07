using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace RazorPagesCar.Models
{
    public class Car
    {
        public int ID { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public List<RazorPagesCar.Models.Review> Reviews {get; set;}
        public string Make { get; set; }
        public string Model { get; set; }
        [Display(Name = "Number of Doors")]
        public int NumberOfDoors { get; set; }
        public int Cylinders { get; set; }
    }
}