using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }

        //Relationships

        public List<Clothing> Clothings { get; set; }
    }
}
