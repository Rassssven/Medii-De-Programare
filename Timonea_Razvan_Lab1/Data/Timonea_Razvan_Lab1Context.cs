using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Timonea_Razvan_Lab1.Models;

namespace Timonea_Razvan_Lab1.Data
{
    public class Timonea_Razvan_Lab1Context : DbContext
    {
        public Timonea_Razvan_Lab1Context (DbContextOptions<Timonea_Razvan_Lab1Context> options)
            : base(options)
        {
        }

        public DbSet<Timonea_Razvan_Lab1.Models.Book> Book { get; set; } = default!;

        public DbSet<Timonea_Razvan_Lab1.Models.Publisher>? Publisher { get; set; }

        public DbSet<Timonea_Razvan_Lab1.Models.Author>? Author { get; set; }

        public DbSet<Timonea_Razvan_Lab1.Models.Category>? Category { get; set; }
    }
}
