using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayHomeAway.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolidayHomeAway.Components
{
    public class TypeAccomMenu :ViewComponent
    {
        private readonly ITypeRepo _typeRepo;

        public TypeAccomMenu(ITypeRepo typeRepo)
        {
            _typeRepo = typeRepo;

        }

        public IViewComponentResult Invoke()
        {
            var types = _typeRepo.Types.OrderBy(t => t.Name);
            return View(types);
        }
    }
}
