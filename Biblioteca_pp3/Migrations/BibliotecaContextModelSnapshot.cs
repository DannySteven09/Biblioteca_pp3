﻿// <auto-generated />
using System;
using Biblioteca_pp3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Biblioteca_pp3.Migrations
{
    [DbContext(typeof(BibliotecaContext))]
    partial class BibliotecaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Biblioteca_pp3.Models.Autor", b =>
                {
                    b.Property<int>("AutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AutorId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutorId");

                    b.ToTable("Autores");

                    b.HasData(
                        new
                        {
                            AutorId = 1,
                            Apellido = "García Márquez",
                            FechaNac = new DateTime(1927, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Gabriel"
                        },
                        new
                        {
                            AutorId = 2,
                            Apellido = "Cortázar",
                            FechaNac = new DateTime(1914, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Julio"
                        },
                        new
                        {
                            AutorId = 3,
                            Apellido = "Vargas Llosa",
                            FechaNac = new DateTime(1936, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Mario"
                        },
                        new
                        {
                            AutorId = 4,
                            Apellido = "Allende",
                            FechaNac = new DateTime(1942, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Isabel"
                        },
                        new
                        {
                            AutorId = 5,
                            Apellido = "Fuentes",
                            FechaNac = new DateTime(1928, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Carlos"
                        });
                });

            modelBuilder.Entity("Biblioteca_pp3.Models.Libro", b =>
                {
                    b.Property<int>("LibroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibroId"));

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPub")
                        .HasColumnType("datetime2");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibroId");

                    b.HasIndex("AutorId");

                    b.ToTable("Libros");

                    b.HasData(
                        new
                        {
                            LibroId = 1,
                            AutorId = 1,
                            FechaPub = new DateTime(1967, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ISBN = "978-0307474728",
                            Titulo = "Cien años de soledad"
                        },
                        new
                        {
                            LibroId = 2,
                            AutorId = 2,
                            FechaPub = new DateTime(1963, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ISBN = "978-8437600918",
                            Titulo = "Rayuela"
                        },
                        new
                        {
                            LibroId = 3,
                            AutorId = 3,
                            FechaPub = new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ISBN = "978-8420471839",
                            Titulo = "La ciudad y los perros"
                        },
                        new
                        {
                            LibroId = 4,
                            AutorId = 4,
                            FechaPub = new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ISBN = "978-0553383805",
                            Titulo = "La casa de los espíritus"
                        },
                        new
                        {
                            LibroId = 5,
                            AutorId = 5,
                            FechaPub = new DateTime(1958, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ISBN = "978-9684113408",
                            Titulo = "La región más transparente"
                        });
                });

            modelBuilder.Entity("Biblioteca_pp3.Models.Libro", b =>
                {
                    b.HasOne("Biblioteca_pp3.Models.Autor", "Autor")
                        .WithMany("Libros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("Biblioteca_pp3.Models.Autor", b =>
                {
                    b.Navigation("Libros");
                });
#pragma warning restore 612, 618
        }
    }
}
