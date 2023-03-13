﻿using DataAccess.Entity;
using Services.DTOClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServicesInterface
{
    public interface IUserServices
    {
        public Task<List<User>> GetInfo();
        public Task<UserDTO[]> GetUserInfo();
        public Task<string> AddUser(User user);
    }
}
