using WebApplication2.Data;
using WebApplication2.IRepository;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class CategoryRepository : IcategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;

        }
        public void Addcategory(category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Deletecategory(int id)
        {
            var catg = _context.Categories.Find(id);
            if (catg != null)
            {
                _context.Categories.Remove(catg);
                _context.SaveChanges();
            }
        }

        public IEnumerable<category> GetAllcategory()
        {
            return _context.Categories.ToList();
           
        }

        public category Getbyid(int id)
        {
            var category = _context.Categories.Find(id);
            return category;
        }

        public void Updatecategory(category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }
    }
}
