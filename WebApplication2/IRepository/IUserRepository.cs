using WebApplication2.Models;
using System.Collections.Generic;

namespace WebApplication2.IRepository
{
    public interface IUserRepository
    {
        IEnumerable<user> GetAllUsers();
        user GetById(int id);

        void AddUser(user user);
        void DeleteUser(int id);
        void UpdateUser(user user);
    }
}
