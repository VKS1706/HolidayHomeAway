using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using HolidayHomeAway.Models;
using HolidayHomeAway.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HolidayHomeAway.Controllers
{
    [Authorize(Roles = "Administrators")]
    public class AccomManagementController : Controller
    {
        private readonly IAccomRepo _accomRepo;
        private readonly ITypeRepo _typeRepo;

        public AccomManagementController(IAccomRepo accomRepo, ITypeRepo typeRepo)
        {
            _accomRepo = accomRepo;
            _typeRepo = typeRepo;
        }
        public IActionResult Index()
        {
            var accom = _accomRepo.AllAccom.OrderBy(a => a.Id);

            return View(accom);
        }

        public IActionResult AccomManagement(string type)
        {
            IEnumerable<Accom> accoms;
            string currentType = string.Empty;

            if (string.IsNullOrEmpty(type))
            {
                accoms = _accomRepo.AllAccom.OrderBy(a => a.Id);
                currentType = "All Accoms";
            }
            else
            {
                accoms = _accomRepo.AllAccom.Where(a => a.AccomType.Name == type)
                    .OrderBy(a => a.Id);
                currentType = _typeRepo.Types.FirstOrDefault(t => t.Name == type).Name;
            }

            return View(new AccomManagementViewModel()
            {
                Accoms = accoms,
                CurrentType = currentType
            });
        }

        public IActionResult AddAccom()
        {
            var types = _typeRepo.Types;
            var accomEditViewModel = new AccomEditViewModel
            {
                Types = types.Select(t => new SelectListItem()
                {
                    Text = t.Name, 
                    Value = t.Id.ToString()
                }).ToList(),
                TypeId = types.FirstOrDefault().Id
            };
            return View(accomEditViewModel);
        }

        [HttpPost]
        public IActionResult AddAccom(AccomEditViewModel accomEditViewModel)
        {
            //Basic validation
            if (ModelState.IsValid)
            {
                _accomRepo.CreateAccom(accomEditViewModel.Accom);
                return RedirectToAction("Index");
            }
            return View(accomEditViewModel);
        }

        public IActionResult EditAccom(int accomId)
        {
            var types = _typeRepo.Types;
            var accom = _accomRepo.AllAccom.FirstOrDefault(a => a.Id == accomId);
            var accomEditViewModel = new AccomEditViewModel
            {
                Types = types.Select(t => new SelectListItem()
                {
                    Text = t.Name,
                    Value = t.Id.ToString()
                }).ToList(),
                Accom = accom,
                TypeId = accom.AccomTypeId
            };

            var item = accomEditViewModel.Types.FirstOrDefault
                (t => t.Value == accom.AccomTypeId.ToString());
            item.Selected = true;

            return View(accomEditViewModel);
        }

        [HttpPost]
        public IActionResult EditAccom(AccomEditViewModel accomEditViewModel)
        {
            accomEditViewModel.Accom.AccomTypeId = accomEditViewModel.TypeId;

            if (ModelState.IsValid)
            {
                _accomRepo.UpdateAccom(accomEditViewModel.Accom);
                return RedirectToAction("Index");
            }
            return View(accomEditViewModel);
        }

        [HttpPost]
        public IActionResult DeleteAccom(string accomId)
        {
            return View();
        }
    }
}