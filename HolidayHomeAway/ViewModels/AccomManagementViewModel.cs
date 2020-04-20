using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayHomeAway.Models;

namespace HolidayHomeAway.ViewModels
{
    public class AccomManagementViewModel
    {
        public IEnumerable<Accom> Accoms{ get; set; }
        public string CurrentType { get; set; }


    }
}
