using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
using demomvc.Data;
using System.Linq;

namespace demomvc.Controllers
{
    public class ContactoController:Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View(_context.DataContactos.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contacto objContacto)
        {
            _context.Add(objContacto);
            _context.SaveChanges();
            ViewData["Message"] = "El contacto ya esta registrado";
            return View("Index");
        }

    }
}