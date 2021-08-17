using System;
using System.Collections.Generic;

namespace ReservationRestApi.Repository.Contract
{
    public interface IGuestRepository<T>
    {
        IEnumerable<T> GetAllGuest();
    }
}
