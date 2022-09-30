using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ViandasUtn.Controllers
{
    public class ProductoController : Controller
    {
        // ver 
                List<Producto> productos = new List<Producto>
        {
            new Producto{ IdProducto = "1", Nombre = "Cafe", Precio = 200, Cantidad = 2 }, // como poner cantidad
            new Producto{ IdProducto = "3", Nombre = "Tostado", Precio = 450, Cantidad = 1  },
            new Producto{ IdProducto = "5", Nombre = "Alfajor", Precio = 150, Cantidad = 3  }
        };

        // GET: ProductoController
        public ActionResult Index()
        {
            return View();
        }
        //  CRUD 

        [HttpGet("[controller]/Lista")]
        public IEnumerable<Producto> Lista()
        {
            return Enumerable.Range(1, 5).Select(index => new Producto
            {
                IdProducto = idProducto,
                Nombre = nombre,
                Precio = precio,
                Cantidad = cantidad
        })
            .ToArray();
        }

        [HttpPost("[controller]/Agregar")]
        public IEnumerable<Producto> Agregar()
        {
            return Enumerable.Range(1, 5).Select(index => new Producto // ?? como agregar y borrar
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55)
            })
            .ToArray();
        }

        [HttpDelete("[controller]/Borrar")]
        public IEnumerable<Producto> Borrar()
        {
            return Enumerable.Range(1, 5).Select(index => new Producto
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55)
            })
            .ToArray();
        }

        // GET: ProductoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
