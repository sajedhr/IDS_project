using WebApplication2.Models;

namespace WebApplication2.IRepository
{
    public interface IcategoryRepository
    {
        IEnumerable<category> GetAllcategory();
        category Getbyid(int id);

        void Addcategory(category category);

        void Updatecategory(category category);
        void Deletecategory(int id);

    }
}
