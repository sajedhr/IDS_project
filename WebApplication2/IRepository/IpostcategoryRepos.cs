using WebApplication2.Models;

namespace WebApplication2.IRepository
{
    public interface IpostcategoryRepos
    {
        IEnumerable<postcategory> GetAllpostcategory();
        postcategory Getbyid(int id);

        void Addpostcategory(postcategory postcategory);
        void Updatepostcategory(postcategory postcategory);
        void Deletepostcategory(int id);

    }
}
