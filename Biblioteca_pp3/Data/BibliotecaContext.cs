using Microsoft.EntityFrameworkCore;
using Biblioteca_pp3.Models;
using System;

namespace Biblioteca_pp3.Data
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar la relación entre Autores y Libros
            modelBuilder.Entity<Libro>()
                .HasOne(l => l.Autor)
                .WithMany(a => a.Libros)
                .HasForeignKey(l => l.AutorId);

            // Semilla de datos para Autores
            modelBuilder.Entity<Autor>().HasData(
                new Autor { AutorId = 1, Nombre = "Gabriel", Apellido = "García Márquez", FechaNac = new DateTime(1927, 3, 6) },
                new Autor { AutorId = 2, Nombre = "Julio", Apellido = "Cortázar", FechaNac = new DateTime(1914, 8, 26) },
                new Autor { AutorId = 3, Nombre = "Mario", Apellido = "Vargas Llosa", FechaNac = new DateTime(1936, 3, 28) },
                new Autor { AutorId = 4, Nombre = "Isabel", Apellido = "Allende", FechaNac = new DateTime(1942, 8, 2) },
                new Autor { AutorId = 5, Nombre = "Carlos", Apellido = "Fuentes", FechaNac = new DateTime(1928, 11, 11) }
            );

            // Semilla de datos para Libros
            modelBuilder.Entity<Libro>().HasData(
                new Libro { LibroId = 1, Titulo = "Cien años de soledad", AutorId = 1, FechaPub = new DateTime(1967, 5, 30), ISBN = "978-0307474728" },
                new Libro { LibroId = 2, Titulo = "Rayuela", AutorId = 2, FechaPub = new DateTime(1963, 6, 28), ISBN = "978-8437600918" },
                new Libro { LibroId = 3, Titulo = "La ciudad y los perros", AutorId = 3, FechaPub = new DateTime(1963, 1, 1), ISBN = "978-8420471839" },
                new Libro { LibroId = 4, Titulo = "La casa de los espíritus", AutorId = 4, FechaPub = new DateTime(1982, 1, 1), ISBN = "978-0553383805" },
                new Libro { LibroId = 5, Titulo = "La región más transparente", AutorId = 5, FechaPub = new DateTime(1958, 1, 1), ISBN = "978-9684113408" }
            );
        }
    }
}