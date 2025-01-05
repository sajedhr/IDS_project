using WebApplication2.Models;

namespace WebApplication2.IRepository
{
    public interface IVoteRepository
    {
        IEnumerable<vote> GetAllvote();
        vote Getbyid(int id);

        void Addvote(vote vote);
  
        void Deletevote(int id);

    }
}
