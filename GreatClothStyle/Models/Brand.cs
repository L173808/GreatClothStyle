using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreatClothStyle.Models
{
    public class Brand
    {
        public int id { get; set; }

        [Display(Name = "Brand Name")]
        public string Name { get; set; }


        [Display(Name = "Contact")]
        public string Contact { get; set; }


        [Display(Name = "Address")]
        public string Address { get; set; }



    }
}
