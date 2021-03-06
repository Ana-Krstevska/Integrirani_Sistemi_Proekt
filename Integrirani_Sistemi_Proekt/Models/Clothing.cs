using Integrirani_Sistemi_Proekt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Models
{
    public class Clothing
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        public double Price { get; set; }

        [Display(Name = "Picture")]
        public string ImageUrl { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int AmountXS { get; set; }

        public int AmountS { get; set; }

        public int AmountM { get; set; }

        public int AmountL { get; set; }

        public int AmountXL { get; set; }

        //Relationships

        public List<Tag_Clothing> Tag_Clothings { get; set; }

        // Brand
        
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }

        // Shop

        public int ShopId { get; set; }
        [ForeignKey("ShopId")]
        [Display(Name="Shop")]
        public Shop Shop { get; set; }
    }
}
