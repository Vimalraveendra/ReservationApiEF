using System;
using System.Collections.Generic;
using System.Linq;
using ReservationRestApi.Model;
using ReservationRestApi.Repository.Contract;

namespace ReservationRestApi.Repository.Implementation
{
    public class GuestRepository : IGuestRepository<Guest>
    {
        readonly ReservationContext _reservationContext;

        public GuestRepository(ReservationContext context)
        {
            _reservationContext = context;
        }

       

        public IEnumerable<Guest> GetAllGuest()
        {
            return _reservationContext.Guests.ToList();
        }


    }
}
