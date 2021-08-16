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
            double operacion=0;
            double total;
            double igv = 1.18;
            
            ViewData["Message"] = "Sin resultado";
        
                operacion = objproducto.Precio * objproducto.Cantidad;
                total = operacion * igv;
                ViewData["Product"] = "El producto es "+ objproducto.Nombre;
                ViewData["Sub"] = "El subtotal es "+ "S/." + operacion ;
                ViewData["Tot"] = "El total es "+ "S/." + total ;

            return View("Index");
        }

    }
}