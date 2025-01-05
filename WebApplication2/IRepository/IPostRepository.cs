using WebApplication2.Models;

namespace WebApplication2.IRepository
{
    public interface IPostRepository
    {
        IEnumerable<post> GetAllPost();
        post Getbyid(int id);
        
        void AddPost(post post);
        void UpdatePost(post post);
        void DeletePost(int id);
     
      
    }
}
