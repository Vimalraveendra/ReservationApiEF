using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservationRestApi.Model
{
    public class Reservation
    {   
        public int ReservationId { get; set; }
        [Required,MaxLength(10)]
        public  string ReservationCode { get; set; }

        [Column(TypeName = "Date"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreationDate { get; set; }

        public double Price { get; set; }

        [Column(TypeName = "Date"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CheckInDate { get; set; }

        [Column(TypeName = "Date"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CheckOutDate { get; set; }

        public string Currency { get; set; }

        public decimal? commission { get; set; }

        public ICollection<Guest>Guest { get; set; }

    }
}
