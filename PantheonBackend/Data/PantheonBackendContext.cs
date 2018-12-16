using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PantheonBackend.Models;

namespace PantheonBackend.Models
{
    public class PantheonBackendContext : DbContext
    {
        public PantheonBackendContext (DbContextOptions<PantheonBackendContext> options)
            : base(options)
        {
        }

        public DbSet<PantheonBackend.Models.Country> Country { get; set; }

        public DbSet<PantheonBackend.Models.God> God { get; set; }

        public DbSet<PantheonBackend.Models.Hero> Hero { get; set; }
    }
}
