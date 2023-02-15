using AutoMapper;
using ViandasUtn.Context;
using ViandasUtn.Models;

namespace ViandasUtn.Repositories
{
    public class UserRepository : IUsuarioRepository
    {

        private ViandaApiContext _context;
        private readonly IMapper _mapper;
        public UserRepository(ViandaApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Usuario? GetById(int userId)
        {
            return _context.Usuarios.SingleOrDefault(u => u.Id == userId);
        }

        public Usuario? ValidateUser(AuthenticationRequestBody authRequestBody)
        {
            return _context.Usuarios.FirstOrDefault(p => p.UserName == authRequestBody.UserName && p.Password == authRequestBody.Password);
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public void Create(CreateAndUpdateUserDto dto)
        {
            _context.Usuarios.Add(_mapper.Map<Usuario>(dto));
        }

        public void Update(CreateAndUpdateUserDto dto)
        {
            _context.Usuarios.Update(_mapper.Map<Usuario>(dto));
        }

        public void Delete(int id)
        {
            _context.Usuarios.Remove(_context.Usuarios.Single(u => u.Id == id));
        }
    }
}