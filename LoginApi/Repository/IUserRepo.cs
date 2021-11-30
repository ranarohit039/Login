using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LoginApi.Models;

namespace LoginApi.Repository
{
    public interface IUserRepo
    {
        Task<IEnumerable<User>> GetUsers();
        User GetUserById(Guid id);
        void AddUser(User user);
        void DeleteUser(User user);
    }
}