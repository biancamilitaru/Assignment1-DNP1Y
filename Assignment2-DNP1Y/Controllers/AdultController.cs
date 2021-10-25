using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1_DNP1Y.Data;
using Assignment2_DNP1Y.Persistence;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Assignment2_DNP1Y.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultController : ControllerBase
    {
        private IFileContext iFileContext;

        public AdultController(IFileContext iFileContext)
        {
            this.iFileContext = iFileContext;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults([FromQuery] string? name)
        {
            try
            {
                IList<Adult> adults = await iFileContext.GetAdultsAsync();
                if (name != null)
                {
                    adults = adults.Where(t => t.FirstName.ToLower().StartsWith(name.ToLower())
                                               || t.LastName.ToLower().StartsWith(name.ToLower())).ToList();
                }

                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult)
        {
            try
            {
                Adult adultAdded = await iFileContext.AddAdultAsync(adult);
                return Created($"/{adultAdded.Id}", adultAdded);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

    }
}