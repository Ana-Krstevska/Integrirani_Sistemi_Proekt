using Integrirani_Sistemi_Proekt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Season")]
        [Required(ErrorMessage = "Season is required")]
        public string Season { get; set; }

        [Display(Name = "Clothing Piece")]
        [Required(ErrorMessage ="Clothing Piece is required")]
        public ClothingPiece ClothingPiece { get; set; }

        [Display(Name = "Fabric")]
        [Required(ErrorMessage = "Fabric is required")]
        public string Fabric { get; set; }

        //Relationships

        public List<Tag_Clothing> Tag_Clothings { get; set; }
    }
}
