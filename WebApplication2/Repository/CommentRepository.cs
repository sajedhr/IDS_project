using WebApplication2.Data;
using WebApplication2.IRepository;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _context;

        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public void Addcomment(comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public void Deletecomment(int id)
        {
            var comment = _context.Comments.Find(id);
            if (comment != null)
            {
                _context.Comments.Remove(comment);
                _context.SaveChanges();
            }
        }

    

        public IEnumerable<comment> GetAllcomments()
        {
           return _context.Comments.ToList();
        }

        

        public comment Getbyid(int id)
        {
            var comment = _context.Comments.Find(id);
            return comment;
        }

        public void Updatecomment(comment comment)
        {
            _context.Comments.Update(comment);
            _context.SaveChanges();
        }

       
    }
}
      