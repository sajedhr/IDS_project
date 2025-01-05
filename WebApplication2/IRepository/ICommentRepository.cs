using WebApplication2.Models;

namespace WebApplication2.IRepository
{
    public interface ICommentRepository
    {
        IEnumerable<comment> GetAllcomments();
        comment Getbyid(int id);

        void Addcomment(comment comment);
        void Updatecomment(comment comment);
        void Deletecomment(int id);
     
       
    }
}
