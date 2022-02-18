using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VacationRental.Domain.Entities
{
    public class Booking
    {
        private static int _newId;

        public Booking()
        {
            Id = _newId;
            _newId++;
        }

        [Key]
        public int Id { get;  private set; }
        public List<DateTime> BookingDates { get; set; }
        public List<DateTime> PreparationTimeDates { get; set; }
        public Unit Unit { get; set; }
    }
}
