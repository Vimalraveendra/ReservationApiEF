using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservationRestApi.Model
{
    public class Guest
    {
        [Key]
        [Required]
       public int GuestId { get; set; }

        [Required]
       public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Column(TypeName = "Date"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DOB { get; set; }

        public double? PostalCode { get; set; }

        public Reservation Reservation { get; set; }

        [ForeignKey("ReservationId")]
        public int ReservationId { get; set; }
     
    }
}
