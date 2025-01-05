using WebApplication2.Data;
using WebApplication2.IRepository;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class PostCategory : IpostcategoryRepos
    {
        private readonly ApplicationDbContext _context;

        public PostCategory(ApplicationDbContext context)
        {
            _context = context;

        }
        public void Addpostcategory(postcategory postcategory)
        {
            _context.Postcategories.Add(postcategory);
            _context.SaveChanges();

        }

        public void Deletepostcategory(int id)
        {
            var postcateg = _context.Postcategories.Find(id);
            if (postcateg != null)
            {
                _context.Postcategories.Remove(postcateg);
                _context.SaveChanges();
            }
        }

        public IEnumerable<postcategory> GetAllpostcategory()
        {
            return _context.Postcategories.ToList();
        }

        public postcategory Getbyid(int id)
        {
            var postcateg = _context.Postcategories.Find(id);
            return postcateg;
        }

        public void Updatepostcategory(postcategory postcategory)
        {
            _context.Postcategories.Update(postcategory);
            _context.SaveChanges();
        }
    }
}
