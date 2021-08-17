using System;
using System.Collections.Generic;
using ReservationRestApi.Model;

namespace ReservationRestApi.Repository.Contract
{
    public interface IGuestRepository<T>
    {
        IEnumerable<T> GetAllGuest();
        Guest AddGuest(Guest guest);
        void DeleteGuest(string name);
    }
}
