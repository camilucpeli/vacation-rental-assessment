using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VacationRental.Domain.Entities
{
    public class Rental
    {
        private static int _newId;

        public Rental()
        {
            Id = _newId;
            _newId++;
        }

        [Key]
        public int Id { get; private set; }
        public List<Unit> Units { get; set; }
    }
}
