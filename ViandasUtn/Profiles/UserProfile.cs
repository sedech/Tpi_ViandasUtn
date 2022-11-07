using AutoMapper;
using ViandasUtn.Models;

namespace ViandasUtn.Profiles
{
    public class UserProfile : Profile  
    {
        public UserProfile()
        {
            CreateMap<Usuario, CreateAndUpdateUserDto>();
        }
    }
}
