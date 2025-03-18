using System;
using System.Collections.Generic;

namespace Biblioteca_pp3.Models
{
    public class Autor
    {
        public int AutorId { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public DateTime FechaNac { get; set; }

        // Inicializar la colección para evitar null
        public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();

        // Propiedad calculada para mostrar el nombre completo
        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}