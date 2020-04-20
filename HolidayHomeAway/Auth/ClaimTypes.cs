using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayHomeAway.Auth
{
    public class ClaimTypes //Can be deleted.
    {
        public static List<string> ClaimsList { get; set; } = new List<string>
        {
            "Delete Accom",
            "Add Accom",
            "Age for Ordering"
        };
    }
}
