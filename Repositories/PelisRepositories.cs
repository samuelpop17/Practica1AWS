using Microsoft.EntityFrameworkCore;
using practicaaws.Data;
using practicaaws.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaaws.Repositories
{
    public class PelisRepository
    {

        private PelisContext context;

        public PelisRepository(PelisContext context)
        {
            this.context = context;
        }

        public async Task<List<Peli>> GetPelisAsync()

        {

            return await this.context.Pelis.ToListAsync();

        }

        public async Task<List<Peli>> GetPelisActoresAsync(string actor)

        {

            return await this.context.Pelis.Where(p => p.Actores.Contains(actor)).ToListAsync();

        }
    }
}
