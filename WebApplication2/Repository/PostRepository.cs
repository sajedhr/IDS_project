using WebApplication2.Data;
using WebApplication2.IRepository;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;

        }
        public void AddPost(post post)
        {
           _context.Posts.Add(post);
           _context.SaveChanges();
        }

        public void DeletePost(int id)
        {
            var current_post = _context.Posts.Find(id);
            if (current_post != null)
            {
                _context.Posts.Remove(current_post);
                _context.SaveChanges();

                                    
            }

            

        }

        public IEnumerable<post> GetAllPost()
        {
           return _context.Posts.ToList();
        }

        public post Getbyid(int id)
        {
            var post = _context.Posts.Find(id);
            return post;

        }

        public void UpdatePost(post post)
        {
        
            _context.Posts.Update(post);
            _context.SaveChanges();
        }
    }
}
