using DataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.ServicesInterface;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _User;
        public UserController(IUserServices user)
        {
            _User = user;
        }
        [HttpGet]
        public async Task<IActionResult> Info()
        {
            var UserAllData=await _User.GetInfo();
            return Ok(UserAllData);
        }
        [HttpGet]
        public async  Task<IActionResult> UserInfo() 
        {
            var UserLimitedData=await _User.GetUserInfo();
            return Ok(UserLimitedData);
        }
    }
}
