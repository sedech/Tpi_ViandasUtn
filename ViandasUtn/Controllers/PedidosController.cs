using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViandasUtn.Models;
using ViandasUtn.Repositories;

namespace ViandasUtn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoRepository _pedidoRepository;
        public PedidosController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

       
        [HttpGet]
        public ActionResult<ICollection<PedidoDto>?> GetPedidos()

        {
            var prod = _pedidoRepository.GetAll();

            if (prod == null)
                return NotFound();
            return Ok(prod);
        }
        [HttpGet("{pedidoId}")]
        public ActionResult<PedidoDto> GetProducto(int pedidoId)
        {


            var pedido = _pedidoRepository.GetById(pedidoId);

            if (pedido is null)
                return NotFound();

            return Ok(pedido);
        }

        [HttpDelete("{pedidoId}")]
        public ActionResult<PedidoDto> DeletePedido(int pedidoId)
        {


            var pedidoToDelete = _pedidoRepository.GetById(pedidoId);
            if (pedidoToDelete is null)
                return NotFound();

            var result = _pedidoRepository.DeletePedido(pedidoId);

            if (result is null) return NoContent();
            return BadRequest();


        }

        [HttpPut("pedidoId")]


        public ActionResult Update(PedidoToCreationAndUpdateDto prodToUpdate, int pedidoId)
        {
            if (prodToUpdate is null)
                return NotFound();


            var result = _pedidoRepository.UpdatePedido(prodToUpdate, pedidoId);


            if (result is false)
                return BadRequest();

            return NoContent();


        }

        [HttpPost]

        public ActionResult Add(PedidoToCreationAndUpdateDto newProd)
        {
            if (newProd is null) return BadRequest();


            var result = _pedidoRepository.AddProducto(newProd);

            if (result is false)
                return BadRequest();

            return NoContent();

        }

    }
}
