using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayHomeAway.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HolidayHomeAway.ViewModels
{
    public class AccomEditViewModel
    {
        public Accom Accom { get; set; }
        public List<SelectListItem> Types { get; set; }
        public int TypeId { get; set; }

        public List<SelectListItem>Availabilities { get; set; }
        public int AvaId { get; set; }
    }
}
