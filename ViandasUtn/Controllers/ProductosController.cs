using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViandasUtn.Models;
using ViandasUtn.Repositories;

namespace ViandasUtn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IPedidoRepository _productoRepository;
        public ProductosController(IPedidoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        [Authorize(AuthenticationSchemes = "Bearer")] // necesita aut para usar se necesita el token que me devuelve 
        [HttpGet]
        public ActionResult<ICollection<PedidoDto>?> GetProductos()

        {
           var prod = _productoRepository.GetAll();

            if (prod == null) 
                return NotFound();
            return Ok(prod);
        }
        [HttpGet("{productoId}")]
        public ActionResult<PedidoDto> GetProducto(int productoId)
        {


            var producto = _productoRepository.GetById(productoId);

            if (producto is null)
                return NotFound();

            return Ok(producto);
        }

        [HttpDelete("{productoId}")]
        public ActionResult<PedidoDto> DeleteProducto(int productoId) 
        {


            var productoToDelete = _productoRepository.GetById(productoId);
            if (productoToDelete is null)
                return NotFound();

            var result = _productoRepository.DeleteProducto(productoId);

            if (result) return NoContent();
            return  BadRequest();


        }

        [HttpPut("productoId")]


        public ActionResult Update(PedidoToCreationAndUpdateDto prodToUpdate, int productoId)
        {
            if (prodToUpdate is null)
                return NotFound();


            var result =  _productoRepository.UpdateProducto(prodToUpdate, productoId);


            if (result is false)
                return BadRequest();

            return NoContent();


        }

        [HttpPost]

        public ActionResult Add(PedidoToCreationAndUpdateDto newProd)
        {
            if (newProd is null) return BadRequest();


            var result = _productoRepository.AddProducto(newProd);

            if (result is false)
                return BadRequest();

            return NoContent();

        }



    }
}
