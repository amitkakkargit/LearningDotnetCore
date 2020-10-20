using System.Collections.Generic;
using UnitOfWork.Models;

namespace UnitOfWork.UOW
{
    public interface IUserRepository
    {
        void AddUser(User user);
        IEnumerable<User> GetUsers();
        bool DeleteUser(long userId);
        User GetUser(long Id);
    }
}