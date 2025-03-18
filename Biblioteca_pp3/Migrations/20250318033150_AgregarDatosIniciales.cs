using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Biblioteca_pp3.Migrations
{
    /// <inheritdoc />
    public partial class AgregarDatosIniciales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "AutorId", "Apellido", "FechaNac", "Nombre" },
                values: new object[,]
                {
                    { 1, "García Márquez", new DateTime(1927, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel" },
                    { 2, "Cortázar", new DateTime(1914, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julio" },
                    { 3, "Vargas Llosa", new DateTime(1936, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mario" },
                    { 4, "Allende", new DateTime(1942, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabel" },
                    { 5, "Fuentes", new DateTime(1928, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos" }
                });

            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "LibroId", "AutorId", "CategoriaId", "FechaPub", "ISBN", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(1967, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "978-0307474728", "Cien años de soledad" },
                    { 2, 2, null, new DateTime(1963, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "978-8437600918", "Rayuela" },
                    { 3, 3, null, new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "978-8420471839", "La ciudad y los perros" },
                    { 4, 4, null, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "978-0553383805", "La casa de los espíritus" },
                    { 5, 5, null, new DateTime(1958, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "978-9684113408", "La región más transparente" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 5);
        }
    }
}
