using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sistema_academico.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Docente> Docente { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Alumno>().HasKey(e => e.idAlumno);

            modelBuilder.Entity<Docente>().HasKey(e => e.idDocente);

        }
    }
}
