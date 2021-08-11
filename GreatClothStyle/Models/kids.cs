using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreatClothStyle.Models
{
    public class kids
    {


        public int id { get; set; }

        [Display(Name = "Brand Name")]
        public string Name { get; set; }


        [Display(Name = "Cloth Type")]
        public string CType { get; set; }


        [Display(Name = "Size")]
        public string Size { get; set; }


        [Display(Name = "Price")]
        public int price { get; set; }

        public Brand brand { get; set; }


    }
}
