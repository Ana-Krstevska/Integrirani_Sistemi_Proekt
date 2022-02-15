using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Models
{
    public class Tag_Clothing
    {
        public int ClothingId { get; set; }

        public Clothing Clothing { get; set; }

        public Tag Tag { get; set; }

        public int TagId { get; set; }
    }
}
