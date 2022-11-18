using ViandasUtn.Models;

namespace ViandasUtn.Repositories
{
    public interface IPedidoRepository
    {
        public PedidoDto GetById(int id);
        public ICollection<PedidoDto> GetAll();
        public bool AddProducto (PedidoToCreationAndUpdateDto producto);
        public bool UpdateProducto (PedidoToCreationAndUpdateDto producto, int Id);
        public bool DeleteProducto (int id);
        object DeletePedido(int pedidoId);
        object UpdatePedido(PedidoToCreationAndUpdateDto prodToUpdate, int pedidoId);
    }
}
