using Microsoft.AspNetCore.Mvc;
using PracticoMVC.Models;

public class ProductoController : Controller
{
    public IActionResult Index()
    {
        var productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Mouse", Precio = 1500 },
            new Producto { Id = 2, Nombre = "Teclado", Precio = 2500 }
        };

        return View(productos);
    }
}
