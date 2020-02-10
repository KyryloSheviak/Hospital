using Hospital.DAL.Context;
using Hospital.DAL.Entities;
using Hospital.DAL.Interface;

namespace Hospital.DAL.Repository
{
    public class ClientManager : IClientManager
    {
        protected readonly ApplicationDbContext _context;
        public ClientManager(ApplicationDbContext db)
        {
            _context = db;
        }

        public void Create(Doctor item)
        {
            _context.Doctors.Add(item);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
