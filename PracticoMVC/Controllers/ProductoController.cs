using Microsoft.AspNetCore.Mvc;
using PracticoMVC.Models;

public class ProductoController : Controller
{
    private readonly AppDbContext _context;

    public ProductoController(AppDbContext context)
    {
        _context = context;
    }

    // Método existente para listar productos
    public IActionResult Index()
    {
        var productos = _context.Productos.ToList();
        return View(productos);
    }

    // Mostrar formulario vacío para crear producto
    public IActionResult Crear()
    {
        return View();
    }

    // Recibir datos del formulario y guardarlos en la BD
    [HttpPost]
    public IActionResult Crear(Producto producto)
    {
        if (ModelState.IsValid)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(producto); // Volver al formulario si hay errores
    }
}
