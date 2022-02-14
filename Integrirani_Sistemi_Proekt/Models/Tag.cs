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

        public string Season { get; set; }

        public ClothingPiece ClothingPiece { get; set; }
        
        public string Fabric { get; set; }

        //Relationships

        public List<Tag_Clothing> Tag_Clothings { get; set; }
    }
}
