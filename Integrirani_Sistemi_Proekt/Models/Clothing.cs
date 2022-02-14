using Integrirani_Sistemi_Proekt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Models
{
    public class Clothing
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int AmountXS { get; set; }

        public int AmountS { get; set; }

        public int AmountM { get; set; }

        public int AmountL { get; set; }

        public int AmountXL { get; set; }

    }
}
