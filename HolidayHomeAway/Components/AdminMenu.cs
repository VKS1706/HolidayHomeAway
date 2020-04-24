using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HolidayHomeAway.Components
{
    public class AdminMenu: ViewComponent
    {
        public IViewComponentResult Invoke() //DropDown list
        {
            var menuItems = new List<AdminMenuItem>
            {
                new AdminMenuItem()
                {
                    DisplayValue = "User Management",
                    ActionValue = "UserManagement"
                },
                new AdminMenuItem()
                {
                    DisplayValue = "Role Management",
                    ActionValue = "RoleManagement"
                },
                new AdminMenuItem()
                {
                    DisplayValue = "Accom Management",
                    ActionValue = "AccomManagement"
                },
                new AdminMenuItem()
                {
                    DisplayValue = "Order Management",
                    ActionValue = "OrderManagement"
                }
                
            };
            return View(menuItems);

        }



    }

    public class AdminMenuItem
    {
        public string DisplayValue { get; set; }
        public string ActionValue { get; set; }
    }
}
