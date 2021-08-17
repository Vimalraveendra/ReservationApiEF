using System;
using System.Collections.Generic;
using System.Linq;
using ReservationRestApi.Model;
using ReservationRestApi.Repository.Contract;

namespace ReservationRestApi.Repository.Implementation
{
    public class ReservationRepository : IReservationRepository<Reservation>
    {
        readonly ReservationContext _reservationContext;

        public ReservationRepository(ReservationContext context)
        {
            _reservationContext = context;
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationContext.Reservations.ToList();
        }

        public void DeleteAllReservation()
        {
            var itemsToDelete = _reservationContext.Set<Reservation>();
            _reservationContext.Reservations.RemoveRange(itemsToDelete);
           _reservationContext.SaveChanges();
        }
            
    }
}
