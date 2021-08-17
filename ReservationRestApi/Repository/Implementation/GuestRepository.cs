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

        public Guest AddGuest(Guest guest)
        {
                try
                {
                    if (_reservationContext != null)
                    {
                        _reservationContext.Add(guest);
                        _reservationContext.SaveChanges();
                        return guest;
                    }
                    else
                    {
                        return null;
                    }
                }
            catch (Exception)
            {
                    //log exception
                    return null;
                }
            }
        

        public IEnumerable<Guest> GetAllGuest()
        {
            return _reservationContext.Guests.ToList();
        }

        public void DeleteGuest(string name)
        {
                var guest = _reservationContext.Guests.Where(b => b.Name == name);
                _reservationContext.Guests.Remove((Guest)guest);
                _reservationContext.SaveChanges();   
            
        }

    }
}
