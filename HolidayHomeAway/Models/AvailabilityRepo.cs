using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayHomeAway.Models
{
    public class AvailabilityRepo :IAvailabilityRepo
    {
        private readonly AppDbContext _appDbContext;

        public AvailabilityRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Availability> Availabilities => _appDbContext.Availabilities; 
    }
}
