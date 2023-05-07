using CriadorDeCaes.Models;
using CriadoresCaes.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CriadoresCaes.Controllers
{
    public class CriadoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CriadoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: Criadores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Criadores.ToListAsync());
        }

        // GET: Criadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Criadores == null)
            {
                return NotFound();
            }

            var criadores = await _context.Criadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (criadores == null)
            {
                return NotFound();
            }

            return View(criadores);
        }

        // GET: Criadores/Create
        public IActionResult Create()
        {
            System.Diagnostics.Debug.WriteLine("teste deby creating 1");
            return View();
        }

        // POST: Criadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,NomeComercial,Morada,CodPostal,Email,Telemovel")] Criadores criadores)
        {
            System.Diagnostics.Debug.WriteLine("teste deby creating 2");
            if (ModelState.IsValid)
            {
                System.Diagnostics.Debug.WriteLine("teste deby creating 3");
                _context.Add(criadores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            System.Diagnostics.Debug.WriteLine("teste deby creating 4");
            return View(criadores);
        }

    }
}
