using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VacationRental.Domain.Entities
{
    public class Unit
    {
        private static int _newId;

        public Unit()
        {
            Id = _newId;
            _newId++;
        }

        [Key]
        public int Id { get; private set; }
    }
}
