using Microsoft.EntityFrameworkCore;
using practicaaws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaaws.Data
{
    public class PelisContext : DbContext
    {
        public PelisContext(DbContextOptions<PelisContext> options)

           : base(options) { }



        public DbSet<Peli> Pelis { get; set; }
    }
}
