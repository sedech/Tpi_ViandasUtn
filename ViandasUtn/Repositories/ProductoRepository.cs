using AutoMapper;
using ViandasUtn.Context;
using ViandasUtn.Models;

namespace ViandasUtn.Repositories
{
    public class ProductoRepository : Repository, IProductoRepository
    {
        private readonly IMapper _mapper; //mapear Dto a entidad o al reves 

        public ProductoRepository(ViandaApiContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public ViandaApiContext Get_context()
        {
            return _context;
        }

        public bool AddProducto(PedidoToCreationAndUpdateDto producto, ViandaApiContext _context)
        {
            var mapped = _mapper.Map<Producto>(producto);
            _ = _context.Productos.Add(mapped);
            return SaveChanges();
            
        }

        public bool DeleteProducto(int id)
        {
             var productoToDelete =_context.Productos.Where(x => x.Id == id).FirstOrDefault();
            if (productoToDelete != null)
            {
                _context.Remove(productoToDelete);
                return SaveChanges(); // si devuelve T todo ok, si no algo anda mal
            }
            return false;
        }

        public ICollection<PedidoDto> GetAll()
        {
            List<Producto>? prod = _context.Productos.ToList();
            return _mapper.Map<ICollection<PedidoDto>>(prod); // mapear collec entidad a producto y al reves 


        }

        public PedidoDto GetById(int id)
        {
            var prod = _context.Productos.Where(_x => _x.Id == id).FirstOrDefault();    
            return _mapper.Map<PedidoDto>(prod);
        }

        public bool UpdateProducto(PedidoToCreationAndUpdateDto producto, int Id)
        {
            Producto? prod = _context.Productos.Where(_x => _x.Id == Id).FirstOrDefault();
                
            prod.Name = producto.Name;
            prod.Price = producto.Price;
            prod.Description = producto.Description;
            return SaveChanges();
        }
    }
}
