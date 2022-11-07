//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace ViandasUtn.Controllers
//{
//    public class ProductoController : Controller
//    {
//        // ver 
//        List<Producto> productos = new List<Producto>()
//        {
//            new Producto( 1, "Cafe",  200,    2), // como poner cantidad
//            new Producto( 3, "Tostado", 450,  1),
//            new Producto( 5, "Alfajor", 150,  3)

//        };


//        // GET: ProductoController
//        public ActionResult Index()
//        {
//            return View();
//        }
//        //  CRUD 

//        [HttpGet("[controller]/Lista")]
//        public IEnumerable<Producto> Lista() // un interface heredan lista, arreglo, conexion como un tipo general
//        {
//            return productos;
//        }

//        [HttpPost("[controller]/Agregar")]
//        public IEnumerable<Producto> Agregar()
//        {

//            Producto p = new Producto(4,"chocotorta", 200, 1);
  
//            productos.Add(p);
//            return productos; 
            
//        }

//        [HttpPut("[controller]/Actualizar")]
//        //
//        public IEnumerable<Producto> Actualizar()
//        {
//            return Enumerable.Range(1, 5).Select(index => new Producto
//            {
//              /// que escribir 
//            })
//            .ToArray();
//        }


//        [HttpDelete("[controller]/Borrar")]
//        public IEnumerable<Producto> Borrar()
//        {
//            return Enumerable.Range(1, 5).Select(index => new Producto
//            {
//                Date = DateTime.Now.AddDays(index),
//                TemperatureC = Random.Shared.Next(-20, 55)
//            })
//            .ToArray();
//        }

//        // GET: ProductoController/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: ProductoController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: ProductoController/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: ProductoController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: ProductoController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: ProductoController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: ProductoController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
