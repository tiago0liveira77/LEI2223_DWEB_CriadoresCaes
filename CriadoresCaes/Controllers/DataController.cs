using CriadorDeCaes.Models;
using CriadoresCaes.Data;
using Microsoft.AspNetCore.Mvc;

namespace CriadoresCaes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DataController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: Criadores
        [HttpGet]
        [Route("getcriadores")]
        public List<Criadores> GetCriadores()
        {
            List<Criadores> criadores = _context.Criadores.ToList();
            return criadores;
        }

        //GET: Criadores2
        [HttpGet]
        [Route("getcriadores2")]
        public IActionResult GetCriadores2()
        {
            List<Criadores> criadores = _context.Criadores.ToList();
            return Json(criadores);
        }
    }
}
