using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayHomeAway.Models
{
    public class MockAvailabilityRepo:IAvailabilityRepo
    {
        public IEnumerable<Availability> Availabilities =>
            new List<Availability>
            {
                new Availability {Id = 1, Name = "High", Description = "High Availability for this holiday let!"},
                new Availability{Id = 2, Name = "Medium", Description = "Medium Availability for this holiday let!"},
                new Availability{Id = 3, Name = "Low", Description = "Low Availability for this holiday let! Book Now!"}
            };
    }
}
