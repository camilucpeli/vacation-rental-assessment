using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using VacationRental.Domain.Entities;

namespace VacationRental.Data
{
    public class VacationRentalContext : DbContext
    {
        public VacationRentalContext(DbContextOptions<VacationRentalContext> options): base(options)
        { }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Unit> Unit { get; set; }
    }
}
