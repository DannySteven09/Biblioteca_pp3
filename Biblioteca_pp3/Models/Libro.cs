using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca_pp3.Models
{
    public class Libro
    {
        public int LibroId { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public int AutorId { get; set; }

        [ForeignKey("AutorId")]
        public virtual Autor? Autor { get; set; }

        public int? CategoriaId { get; set; }

        public DateTime FechaPub { get; set; }

        public string ISBN { get; set; } = string.Empty;
    }
}