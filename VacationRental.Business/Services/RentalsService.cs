using System;
using System.Collections.Generic;
using System.Text;
using VacationRental.Data.Repositories;

namespace VacationRental.Business.Services
{
    public class RentalsService
    {
        private IRentalRepository _rentalsRepository;

        public RentalsService(IRentalRepository repo)
        {
            _rentalsRepository = repo;
        }
    }
}
