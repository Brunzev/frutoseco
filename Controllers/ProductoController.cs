using Microsoft.AspNetCore.Mvc;
using demomvc.Models;


namespace demomvc.Controllers
{
    public class ProductoController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Producto(Producto objproducto)
        {
            int resultado = 0;
            ViewData["Message"] = "Sin resultado";
       
                resultado = objproducto.Precio + objproducto.Cantidad;
        }


    }
}