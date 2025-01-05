using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.IRepository;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class NotficationRepository : InotificationRepository
    {
        private readonly ApplicationDbContext _context;

        public NotficationRepository(ApplicationDbContext context)
        {
            _context = context;

        }
        public void Deletenotification(int id)
        {
            var current_notf = _context.Notifications.Find(id);
            if (current_notf != null)
            {
                _context.Notifications.Remove(current_notf);
                _context.SaveChanges();


            }
        }

        public IEnumerable<notification> GetAllnotification()
        {
            return _context.Notifications.ToList();
        }

        public notification Getbyid(int id)
        {
            
            var notf = _context.Notifications.Find(id);
            return notf;
        }
    }
}
