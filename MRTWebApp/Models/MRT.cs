using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MRTWebApp.Models
{
    public class MRT
    {
        [Required (ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Please enter your IC number or passport number")]
        public string Id { get; set; }

        [Required (ErrorMessage = "Please enter your email")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Please enter your origin)")]
        public string Origin { get; set; }

        [Required (ErrorMessage = "Please enter your destination")]
        public string Destination { get; set; }

        [Required (ErrorMessage = "Please enter quantity of ticket purchased")]
        public int Quantity { get; set; }

        public bool Discount { get; set; }
    }
}