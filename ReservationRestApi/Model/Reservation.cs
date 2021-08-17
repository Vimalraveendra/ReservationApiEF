using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservationRestApi.Model
{
    public class Reservation
    {   
        public int ReservationId { get; set; }
        
        public  string ReservationCode { get; set; }

      
        public DateTime CreationDate= DateTime.Now;

        public double Price { get; set; }

        public DateTime CheckInDate = DateTime.Now;
       
        public DateTime CheckOutDate = DateTime.Now;

        public string Currency { get; set; }

        public decimal? Commission { get; set; }

        public ICollection<Guest>Guest { get; set; }

    }
}
