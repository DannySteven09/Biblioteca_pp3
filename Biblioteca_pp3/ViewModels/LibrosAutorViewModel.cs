using System.Collections.Generic;
using Biblioteca_pp3.Models;

namespace Biblioteca_pp3.ViewModels
{
    public class LibrosAutorViewModel
    {
        public Autor Autor { get; set; }
        public List<Libro> Libros { get; set; }
    }
}