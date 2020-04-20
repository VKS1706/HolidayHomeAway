using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayHomeAway.Models
{
    public interface IAvailabilityRepo
    {
        IEnumerable<Availability> Availabilities { get; }
    }
}
