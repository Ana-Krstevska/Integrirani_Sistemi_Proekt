using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Models
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Picture")]
        [Required(ErrorMessage = "Picture URL is required")]
        public string Logo { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        //Relationships

        public List<Clothing> Clothings { get; set; }
    }
}
