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
    [Route("api/Reservations")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationRepository<Reservation> _ReservationRepository;
        public ReservationController(IReservationRepository<Reservation> ReservationRepository)
        {
            _ReservationRepository = ReservationRepository;
        }

        [HttpGet]
         [Route("GetAllReservations")]

         public IActionResult GetAllReservations()
        {
            IEnumerable<Reservation> authors = _ReservationRepository.GetAllReservations();
            return Ok(authors);
        }

        [HttpDelete("DeleteAllReservations")]
        public void DeleteAllReservation() => _ReservationRepository.DeleteAllReservation();

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
