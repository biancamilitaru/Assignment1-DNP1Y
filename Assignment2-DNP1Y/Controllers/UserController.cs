using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Assignment1_DNP1Y.Data;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2_DNP1Y.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserInterface iUserInterface;

        public UserController(IUserInterface iUserInterface)
        {
            this.iUserInterface = iUserInterface;
        }

        [HttpGet]
        [Route("{userName}")]
        public async Task<ActionResult<User>> GetUserAsync([FromRoute] string userName)
        {
            try
            {
                User user = await iUserInterface.GetUserAsync(userName);
                return Ok(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }

        }
    }
}