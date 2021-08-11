using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GreatClothStyle.Models;

namespace GreatClothStyle.Data
{
    public class GreatClothStyleContext : DbContext
    {
        public GreatClothStyleContext (DbContextOptions<GreatClothStyleContext> options)
            : base(options)
        {
        }

        public DbSet<GreatClothStyle.Models.Brand> Brand { get; set; }

        public DbSet<GreatClothStyle.Models.kids> kids { get; set; }

        public DbSet<GreatClothStyle.Models.Mens> Mens { get; set; }

        public DbSet<GreatClothStyle.Models.Women> Women { get; set; }
    }
}
