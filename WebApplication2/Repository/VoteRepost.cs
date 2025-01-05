using WebApplication2.Data;
using WebApplication2.IRepository;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class VoteRepost : IVoteRepository
    {
        private readonly ApplicationDbContext _context;

        public VoteRepost(ApplicationDbContext context)
        {
            _context = context;

        }
        public void Addvote(vote vote)
        {
            _context.Votes.Add(vote);
            _context.SaveChanges();
            
        }

        public void Deletevote(int id)
        {
            var vote = _context.Votes.Find(id);
            if (vote != null)
            {
                _context.Votes.Remove(vote);
                _context.SaveChanges();
            }
        }

        public IEnumerable<vote> GetAllvote()
        {
           return _context.Votes.ToList();
        }

        public vote Getbyid(int id)
        {
            var vote = _context.Votes.Find(id);
            return vote;
        }
    }
}
