using AutoMapper;
using ViandasUtn.Models;

namespace ViandasUtn.Profiles
{
    public class ProductoProfile: Profile
    {
        public ProductoProfile()
        {
            CreateMap<Producto, PedidoDto>();
            CreateMap<PedidoDto, Producto>();

            CreateMap<PedidoToCreationAndUpdateDto, Producto>();
            CreateMap<Producto, PedidoToCreationAndUpdateDto>();
        }
    }
}
