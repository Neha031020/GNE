using AutoMapper;
using DataAccess.Entity;
using DataAccess.IDataAcces;
using Services.DTOClass;
using Services.ServicesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServicesRepo
{

    public class UserServices : IUserServices
    {
    private readonly IUser _user;
        private readonly IMapper _mapper;
        public UserServices(IUser user,IMapper mapper)
        {
            _user = user;
            _mapper = mapper;
        }

        public async Task<string> AddUser(User user)
        {
            var AddData=await _user.AddUsers(user);
            return AddData;
        }

        public async Task<List<User>> GetInfo()
        {
           var DataInfo=await _user.GetInfo();
            return DataInfo;
        }

        public async Task<UserDTO[]> GetUserInfo()
        {
            var DataInfo =await _user.GetUserInfo();
            var DtoToClass = _mapper.Map<User[], UserDTO[]>(DataInfo);
            return DtoToClass;

        }
    }
}
