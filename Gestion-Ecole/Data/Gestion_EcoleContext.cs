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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher_Group>().HasKey(TG => new
            {
                TG.IdTeacher,
                TG.IdGroupe
            });
            modelBuilder.Entity<Teacher_Group>().HasOne(t => t.teacher).WithMany(TG => TG.Groupes_teachers)
                .HasForeignKey(t => t.IdTeacher);
            modelBuilder.Entity<Teacher_Group>().HasOne(t => t.Groupe).WithMany(TG => TG.Groupes_teachers)
              .HasForeignKey(t => t.IdGroupe);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Gestion_Ecole.Models.Administrator> Administrators { get; set; } = default!;
        public DbSet<Gestion_Ecole.Models.Director> Directors { get; set; } = default!;
        public DbSet<Gestion_Ecole.Models.Student> Students { get; set; } = default!;
        public DbSet<Gestion_Ecole.Models.Teacher> Teachers { get; set; } = default!;
        public DbSet<Gestion_Ecole.Models.Groupe> groupes { get; set; } = default!;
        public DbSet<Gestion_Ecole.Models.Mark> marks { get; set; } = default!;
        public DbSet<Gestion_Ecole.Models.Subject> subjects { get; set; } = default!;
        public DbSet<Gestion_Ecole.Models.Teacher_Group> teacher_Groups { get; set; } = default!;
        public DbSet<Gestion_Ecole.Models.Account> accounts { get; set; } = default!;

    }
}
