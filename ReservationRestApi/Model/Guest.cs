using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservationRestApi.Model
{
    public class Guest
    {
        
       public int GuestId { get; set; }

      
       public string Name { get; set; }

      
        public string LastName { get; set; }

     
        public string Email { get; set; }

      
        public DateTime? DOB { get; set; }

        public double? PostalCode { get; set; }

        public Reservation Reservation { get; set; }

        
        public int ReservationId { get; set; }
     
    }
}
