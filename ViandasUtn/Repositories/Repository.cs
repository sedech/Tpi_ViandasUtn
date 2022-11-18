using ViandasUtn.Context;

namespace ViandasUtn.Repositories
{
    public class Repository
    {
        internal readonly ViandaApiContext _context;

        public Repository(ViandaApiContext context)
        {
            _context = context;

        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
