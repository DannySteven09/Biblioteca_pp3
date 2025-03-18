using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Biblioteca_pp3.Data;
using Biblioteca_pp3.Models;
using Biblioteca_pp3.ViewModels;

namespace Biblioteca_pp3.Controllers
{
    public class AutoresController : Controller
    {
        private readonly BibliotecaContext _context;

        public AutoresController(BibliotecaContext context)
        {
            _context = context;
        }

        // GET: Autores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Autores.ToListAsync());
        }

        // GET: Autores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autor = await _context.Autores
                .Include(a => a.Libros)
                .FirstOrDefaultAsync(m => m.AutorId == id);

            if (autor == null)
            {
                return NotFound();
            }

            return View(autor);
        }

        // GET: Autores/Buscar
        public IActionResult Buscar()
        {
            return View(new BusquedaAutorViewModel());
        }

        // POST: Autores/Buscar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buscar(BusquedaAutorViewModel busqueda)
        {
            if (ModelState.IsValid)
            {
                // Búsqueda de autores por nombre o apellido
                var query = from a in _context.Autores
                            where a.Nombre.Contains(busqueda.TerminoBusqueda) ||
                                  a.Apellido.Contains(busqueda.TerminoBusqueda)
                            select a;

                busqueda.Resultados = await query.ToListAsync();
            }

            return View(busqueda);
        }

        // GET: Autores/LibrosAutor/5
        public async Task<IActionResult> LibrosAutor(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autor = await _context.Autores
                .FirstOrDefaultAsync(m => m.AutorId == id);

            if (autor == null)
            {
                return NotFound();
            }

            // Cargar información completa de libros
            var libros = await _context.Libros
                .Where(l => l.AutorId == id)
                .Include(l => l.Autor)
                .ToListAsync();

            var viewModel = new LibrosAutorViewModel
            {
                Autor = autor,
                Libros = libros
            };

            return View(viewModel);
        }
    }
}