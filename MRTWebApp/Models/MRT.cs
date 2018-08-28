using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace MRTWebApp.Models
{
    public class MRT
    {
        private DateTime dt;
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your IC number or passport number")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter departure date")]
        [DataType(DataType.Date)]
        public DateTime? DepartureDate { get; set; }

        [Required(ErrorMessage = "Please enter return date")]
        [DataType(DataType.Date)]
        public DateTime? ReturnDate { get; set; }
       

        [Required(ErrorMessage = "Please enter your origin)")]
        public string Origin { get; set; }

        [Required(ErrorMessage = "Please enter your destination")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Please enter quantity of ticket purchased")]
        public int Quantity { get; set; }

        public bool Discount { get; set; }
    }
}