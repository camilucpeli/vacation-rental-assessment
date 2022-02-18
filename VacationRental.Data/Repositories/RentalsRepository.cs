using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VacationRental.Domain.Entities;

namespace VacationRental.Data.Repositories
{
    public class RentalsRepository : IRentalRepository
    {
        private VacationRentalContext _context;

        public RentalsRepository(VacationRentalContext context)
        {
            _context = context;
        }

        public Task<Rental> GetByIdAsync(int id)
        {
            return _context.Rentals
                .
                .Find(id)
                .;

            throw new NotImplementedException();
        }
    }
}
