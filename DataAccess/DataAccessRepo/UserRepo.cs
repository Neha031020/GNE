using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.IDataAcces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccessRepo
{
    public class UserRepo : IUser
    {
        private readonly  GneProjectContext _context;
        public UserRepo(GneProjectContext context)
        {
            _context = context;
        }

        public async Task<string> AddUsers(User user)
        {
            try
            {
                var exisitingEmail=await _context.Users.Where(x=>x.UserEmail == user.UserEmail).FirstOrDefaultAsync();
                if (exisitingEmail == null)
                {
                    _context.Users.Add(new User
                    {
                       UserName= user.UserName,
                       UserDepartment=user.UserDepartment,
                       UserSeniorName=user.UserSeniorName,
                       UserSeniorPosition=user.UserSeniorPosition,
                       UserEmail=user.UserEmail,
                       UserTitle=user.UserTitle

                    });
                    await _context.SaveChangesAsync();
                    return ("Added Succesfully......:)");
                }
                return ("User Already Exist");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<User>> GetInfo()
        {
            try
            {
                var exisitingAllData = await _context.Users.ToListAsync();
                return exisitingAllData;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<User[]> GetUserInfo()
        {
            try
            {
                var exisitingAllData = await _context.Users.ToArrayAsync();
                return exisitingAllData;
            }
            catch (Exception)
            {

                throw;
            }
          
        }
    }
}
