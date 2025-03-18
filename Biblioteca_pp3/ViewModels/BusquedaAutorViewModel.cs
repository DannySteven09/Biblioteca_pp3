using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Biblioteca_pp3.Models;

namespace Biblioteca_pp3.ViewModels
{
    public class BusquedaAutorViewModel
    {
        [Required(ErrorMessage = "Por favor ingrese un término de búsqueda")]
        [Display(Name = "Buscar autor")]
        public string TerminoBusqueda { get; set; }

        public List<Autor> Resultados { get; set; } = new List<Autor>();
    }
}