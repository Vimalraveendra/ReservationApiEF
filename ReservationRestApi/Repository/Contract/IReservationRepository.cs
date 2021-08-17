using System;
using System.Collections.Generic;

namespace ReservationRestApi.Repository.Contract
{
    public interface IReservationRepository<T>
    {
        IEnumerable<T> GetAllReservations();
    }
}
