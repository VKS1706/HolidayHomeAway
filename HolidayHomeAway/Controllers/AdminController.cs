using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HolidayHomeAway.Auth;
using HolidayHomeAway.Models;
using HolidayHomeAway.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace HolidayHomeAway.Controllers
{
    [Authorize(Roles = "Administrators")] //Only account with Administrators access can use this controller.
    public class AdminController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAccomRepo _accomRepo;
        private readonly ITypeRepo _typeRepo;
        

        public AdminController(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager, IAccomRepo accomRepo, ITypeRepo typeRepo)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _accomRepo = accomRepo;
            _typeRepo = typeRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserManagement()
        {
            var users = _userManager.Users;

            return View(users);
        }

        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserViewModel addUserViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(addUserViewModel);
            }

            var user = new ApplicationUser()
            {
                UserName = addUserViewModel.UserName,
                Email = addUserViewModel.Email,
                FirstName = addUserViewModel.FirstName,
                LastName = addUserViewModel.LastName,
                BirthDate = addUserViewModel.Birthdate,
                City = addUserViewModel.City,
                Country = addUserViewModel.Country
            };

            IdentityResult result = await _userManager.CreateAsync(user, addUserViewModel.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("UserManagement", _userManager.Users);
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(addUserViewModel);
        }


        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return RedirectToAction("UserManagement", _userManager.Users);
            }

            var vm = new EditUserViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Birthdate = user.BirthDate,
                City = user.City,
                Country = user.Country
            };
            return View(vm);
        }


        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel editUserViewModel)
        {
            var user = await _userManager.FindByIdAsync(editUserViewModel.Id);

            if (user != null)
            {
                user.Email = editUserViewModel.Email;
                user.UserName = editUserViewModel.UserName;
                user.BirthDate = editUserViewModel.Birthdate;
                user.City = editUserViewModel.City;
                user.Country = editUserViewModel.Country;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("UserManagement", _userManager.Users);
                }

                ModelState.AddModelError("", "User not updated, something went wrong.");

                return View(editUserViewModel);
            }

            return RedirectToAction("UserManagement", _userManager.Users);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("UserManagement");
                }
                else
                {
                    ModelState.AddModelError("", "Something went wrong while deleting the user.");
                }
            }
            else
            {
                ModelState.AddModelError("", "This user cannot be found.");
            }

            return View("UserManagement", _userManager.Users);
        }

        
        //Role management
        public IActionResult RoleManagement()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        public IActionResult AddNewRole() => View();

        [HttpPost]
        public async Task<IActionResult> AddNewRole(AddRoleViewModel addRoleViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(addRoleViewModel);
            }

            var role = new IdentityRole
            {
                Name = addRoleViewModel.RoleName
            };

            IdentityResult result = await _roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction("RoleManagement", _roleManager.Roles);
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(addRoleViewModel);
        }

        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                return RedirectToAction("RoleManagement", _roleManager.Roles);
            }

            var editRoleViewModel = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name,
                Users = new List<string>()
            };

            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    editRoleViewModel.Users.Add(user.UserName);
                }
            }

            return View(editRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel editRoleViewModel)
        {
            var role = await _roleManager.FindByIdAsync(editRoleViewModel.Id);

            if (role != null)
            {
                role.Name = editRoleViewModel.RoleName;

                var result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("RoleManagement", _roleManager.Roles);
                }

                ModelState.AddModelError("", "Role not updated.");

                return View(editRoleViewModel);
            }

            return RedirectToAction("RoleManagement", _roleManager.Roles);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRole(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);

            if (role != null)
            {
                var result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleManagement", _roleManager.Roles);
                }
                ModelState.AddModelError("", "Something went wrong while deleting role.");
            }
            else
            {
                ModelState.AddModelError("", "This role cannot bee found.");
            }

            return View("RoleManagement", _roleManager.Roles);
        }

        // adding users to roles
        public async Task<IActionResult> AddUserToRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                return RedirectToAction("RoleManagement", _roleManager.Roles);
            }

            var addUserToRoleViewModel = new UserRoleViewModel { RoleId = role.Id };

            foreach (var user in _userManager.Users)
            {
                if (!await _userManager.IsInRoleAsync(user, role.Name))
                {
                    addUserToRoleViewModel.Users.Add(user);
                }
            }

            return View(addUserToRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddUserToRole(UserRoleViewModel userRoleViewModel)
        {
            var user = await _userManager.FindByIdAsync(userRoleViewModel.UserId);
            var role = await _roleManager.FindByIdAsync(userRoleViewModel.RoleId);

            var result = await _userManager.AddToRoleAsync(user, role.Name);

            if (result.Succeeded)
            {
                return RedirectToAction("RoleManagement", _roleManager.Roles);
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(userRoleViewModel);
        }

        public async Task<IActionResult> DeleteUserFromRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                return RedirectToAction("RoleManagement", _roleManager.Roles);
            }

            var addUserToRoleViewModel = new UserRoleViewModel { RoleId = role.Id };

            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    addUserToRoleViewModel.Users.Add(user);
                }

            }

            return View(addUserToRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUserFromRole(UserRoleViewModel userRoleViewModel)
        {
            var user = await _userManager.FindByIdAsync(userRoleViewModel.UserId);
            var role = await _roleManager.FindByIdAsync(userRoleViewModel.RoleId);

            var result = await _userManager.RemoveFromRoleAsync(user, role.Name);

            if (result.Succeeded)
            {
                return RedirectToAction("RoleManagement", _roleManager.Roles);
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(userRoleViewModel);
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
                return RedirectToAction("AccomManagement");
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
                return RedirectToAction("AccomManagement");
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