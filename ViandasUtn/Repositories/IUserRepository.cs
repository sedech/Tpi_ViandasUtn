using ViandasUtn.Models;

namespace ViandasUtn.Repositories
{
    public interface IUserRepository
    {
        public Usuario? ValidateUser(AuthenticationRequestBody authRequestBody);
        public Usuario? GetById(int userId);
        public List<Usuario> GetAll();
        public void Create(CreateAndUpdateUserDto dto);
        public void Update(CreateAndUpdateUserDto dto);
        public void Delete(int id);
    }
}
