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
        public string Logo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }
}
