using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class UserRepository : IRepository<User>
    {
        private List<User> _users;

        public UserRepository()
        {
            _users = new List<User>();
        }

        public async Task<User> GetById(int id)
        {
            return await Task.FromResult(_users.Find(u => u.Id == id));
        }

        public async Task<List<User>> GetAll()
        {
            return await Task.FromResult(_users);
        }

        public async Task Add(User user)
        {
            _users.Add(user);
            await Task.CompletedTask;
        }

        public async Task Delete(User user)
        {
            _users.Remove(user);
            await Task.CompletedTask;
        }
    }
}
