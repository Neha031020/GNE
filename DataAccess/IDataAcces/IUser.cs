using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IDataAcces
{
    public interface IUser
    {
        public Task<List<User>> GetInfo();
        public Task<User[]> GetUserInfo();
        public Task<string> AddUsers(User user);
    }
}
