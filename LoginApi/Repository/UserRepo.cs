using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginApi.Models;

namespace LoginApi.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly DataContext dc;

        public UserRepo(DataContext dc)
        {
            this.dc = dc;
        }
        public async void AddUser(User user)
        {
           await dc.users.AddAsync(user);
           await dc.SaveChangesAsync();
        }

        public void DeleteUser(User user)
        {
            
            dc.users.Remove(user);
        }

        public  User GetUserById(Guid id)
        {
            return  dc.users.FirstOrDefault(e=>e.UId.Equals(id));
           
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}