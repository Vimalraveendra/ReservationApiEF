using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservationRestApi.Model;
using ReservationRestApi.Repository.Contract;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReservationRestApi.Controllers
{
    [Route("api/Guest")]
    public class GuestController : ControllerBase
    {

         private readonly IGuestRepository<Guest> _guestRepository;

            public GuestController(IGuestRepository<Guest> GuestRepository)
            {
                _guestRepository = GuestRepository;
            }

            [HttpGet]
            [Route("GetAllGuest")]

            public IActionResult GetAllGuest()
            {
                IEnumerable<Guest> authors = _guestRepository.GetAllGuest();
                return Ok(authors);
            }


        [HttpPost]
        [Route("SaveGuest")]
        public IActionResult AddGuest([FromBody] Guest authorparam)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Guest guest = _guestRepository.AddGuest(authorparam);
                    return Ok(guest);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch
            {
                //log Exception
                return BadRequest();
            }
        }

        [HttpDelete("{name}")]
        [Route("DeleteGuest")]
        public void DeleteGuest(string  name)
        { 
              _guestRepository.DeleteGuest(name);
                 
            
        }



        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
