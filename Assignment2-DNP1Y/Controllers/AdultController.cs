using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1_DNP1Y.Data.Adults;
using Assignment2_DNP1Y.DataAccess;
using Assignment2_DNP1Y.Persistence;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Assignment2_DNP1Y.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultController : ControllerBase
    {
        private IAdultsServices adultsServices;

        public AdultController()
        {
            adultsServices = new AdultServices();
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults([FromQuery] string? name)
        {
            try
            {
                IList<Adult> adults = await adultsServices.GetAdultsAsync();
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
                Adult adultAdded = await adultsServices.AddAdultAsync(adult);
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