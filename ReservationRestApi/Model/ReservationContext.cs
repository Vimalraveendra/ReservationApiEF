using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace ReservationRestApi.Model
{
    public class ReservationContext:DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options) : base(options)
        {
            Database.Migrate();
        }

        public static object Reservation { get; internal set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public object Guest { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            
        {
            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.Property(e => e.ReservationCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                .HasColumnType("date");

                entity.Property(e=>e.CheckInDate)
                .HasColumnType("date");

                entity.Property(e => e.CheckOutDate)
                .HasColumnType("date");

                entity.Property(e => e.Commission)
                .HasPrecision(16, 3);


            });

           
            
            modelBuilder.Entity<Guest>(entity =>
            {
                entity.Property(e => e.GuestId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                     .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                .IsRequired();
                entity.Property(e => e.Email)
               .IsRequired();

                entity.HasOne(d => d.Reservation)
                    .WithMany(p => p.Guest)
                    .HasForeignKey(d => d.ReservationId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Guest_Reservation");
            });
        
        
          modelBuilder.Entity<Reservation>().HasData(new Reservation
            {
                ReservationId = 101,
                ReservationCode="Qwertyuw",
                Price= 120,
                Currency="PLN",
                

            },
            new Reservation
            {
                ReservationId = 102,
                ReservationCode = "Asdfghje",
                Price = 150,
                Currency = "PLN",
            },
            new Reservation
            {
                ReservationId = 103,
                ReservationCode = "Zxcvbnm",
                Price = 100,
                Currency = "PLN",
            },
            new Reservation
            {
                ReservationId = 104,
                ReservationCode = "Lkjhgfds",
                Price = 180,
                Currency = "PLN",
            },
            new Reservation
            {
                ReservationId = 105,
                ReservationCode = "Oiuytrew",
                Price = 200,
                Currency = "PLN",
            }

            );
            modelBuilder.Entity<Guest>().HasData(new Guest
            {
                ReservationId = 101,
                GuestId=101,
                Name="John",
                LastName="Honnai",
                Email="john@gmail.com",



            },
            new Guest
            {
                ReservationId = 102,
                GuestId = 102,
                Name = "Adam",
                LastName = "Mathew",
                Email = "adam@gmail.com",
            },
            new Guest
            {
                ReservationId = 103,
                GuestId = 103,
                Name = "Billy",
                LastName = "Brown",
                Email = "billy@gmail.com",
            },
            new Guest
            {
                ReservationId = 104,
                GuestId = 104,
                Name = "Cristopher",
                LastName = "Luis",
                Email = "cristopher@gmail.com",
            },
            new Guest
            {
                ReservationId = 105,
                GuestId = 105,
                Name = "Boss",
                LastName = "Mathew",
                Email = "boss@gmail.com",
            }

            );
        }

       
    }
}
