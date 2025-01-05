using WebApplication2.Models;

namespace WebApplication2.IRepository
{
    public interface InotificationRepository
    {
        IEnumerable<notification> GetAllnotification();
        notification Getbyid(int id);
        void Deletenotification(int id);

    }
}
