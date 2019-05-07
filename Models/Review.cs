using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesCar.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        [Range(1, 5)]
        [Required]
        [Display(Name = "Review")]
        public int CustReview { get; set; }
        [Display(Name = "Review Description")]
        public string CustReviewDesc { get; set; }
        public int CarID {get; set;}
        public Car Car {get; set;}
    }
}