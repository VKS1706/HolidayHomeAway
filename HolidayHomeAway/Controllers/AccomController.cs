using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayHomeAway.Models;
using HolidayHomeAway.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HolidayHomeAway.Controllers
{
    public class AccomController : Controller
    {
        private readonly IAccomRepo _accomRepo;
        private readonly ITypeRepo _typeRepo;
        

        public AccomController(IAccomRepo accomRepo, ITypeRepo typeRepo)
        {
            _accomRepo = accomRepo;
            _typeRepo = typeRepo;
            
        }
        public ViewResult List(string type)
        {
            IEnumerable<Accom> accoms;
            string currentType;

            if (string.IsNullOrEmpty(type))
            {
                accoms = _accomRepo.AllAccom.OrderBy(a => a.Id);
                currentType = "All Types";
            }
            else
            {
                accoms = _accomRepo.AllAccom.Where(a => a.AccomType.Name == type)
                    .OrderBy(a => a.Id);
                currentType = _typeRepo.Types.FirstOrDefault(t => t.Name == type)?.Name;
            }
            return View(new AccomListViewModel
            {
                Accoms = accoms,
                CurrentType = currentType
            });
        }

        public IActionResult Details(int id)
        {
            var accom = _accomRepo.GetByAccomId(id);
            if (accom == null)
            {
                return NotFound();
            }

            return View(accom);
        }
    }
}