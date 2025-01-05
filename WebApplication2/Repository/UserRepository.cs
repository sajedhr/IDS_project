using WebApplication2.Data;
using WebApplication2.IRepository;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context) {
            _context = context;
            
        }
        public void AddUser(user user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Deletevote(int id)
        {
            var current_user= _context.Users.Find(id);
            if (current_user != null)
            {
                _context.Users.Remove(current_user);
                _context.SaveChanges();

            }

        }

        public IEnumerable<user> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public user GetById(int id)
        {
            var user = _context.Users.Find(id);
            return user;
        }

        public void UpdateUser(user user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
