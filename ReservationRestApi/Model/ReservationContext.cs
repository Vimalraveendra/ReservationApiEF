using System;
using Microsoft.EntityFrameworkCore;
namespace ReservationRestApi.Model
{
    public class ReservationContext:DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Guest> Guests { get; set; }
    }
}
