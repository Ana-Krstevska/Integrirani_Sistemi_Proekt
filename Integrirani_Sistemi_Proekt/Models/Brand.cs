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
        public string ProfilePictureUrl { get; set; }

        public string Name { get; set; }

        public string Bio { get; set; }
    }
}
