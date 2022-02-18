using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VacationRental.Domain.Entities;

namespace VacationRental.Data.Repositories
{
    public interface IRentalRepository
    {
        Task<Rental> GetByIdAsync();

    }
}
