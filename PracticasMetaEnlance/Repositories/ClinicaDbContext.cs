using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Repositories
{
    public class ClinicaDbContext : DbContext
    {
        public ClinicaDbContext(DbContextOptions<ClinicaDbContext> options) : base(options){ }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Paciente>().ToTable("Pacientes");
            modelBuilder.Entity<Medico>().ToTable("Medicos");
        }
    }
}
