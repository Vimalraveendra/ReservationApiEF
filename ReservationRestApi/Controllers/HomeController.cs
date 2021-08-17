using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReservationRestApi.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReservationRestApi.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Model.Reservation> reservationList = new List<Reservation>();
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44324/api/Reservations/GetAllReservations"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<Reservation>>(apiResponse);
                }
            }
            return View("Index",reservationList);
        }
            
    }
}
