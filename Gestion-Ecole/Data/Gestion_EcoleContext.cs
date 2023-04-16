using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gestion_Ecole.Models;

namespace Gestion_Ecole.Data
{
    public class Gestion_EcoleContext : DbContext
    {
        public Gestion_EcoleContext (DbContextOptions<Gestion_EcoleContext> options)
            : base(options)
        {
        }

        public DbSet<Gestion_Ecole.Models.Administrator> Administrators { get; set; } = default!;
        public DbSet<Gestion_Ecole.Models.Director> Directors { get; set; } = default!;
        public DbSet<Gestion_Ecole.Models.Student> Students { get; set; } = default!;
        public DbSet<Gestion_Ecole.Models.Teacher> Teachers { get; set; } = default!;
    }
}
