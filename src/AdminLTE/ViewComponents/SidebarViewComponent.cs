using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AdminLTE.Common;
using AdminLTE.Models;
using System.Security.Claims;
using AdminLTE.Common.Extensions;
using System;

namespace AdminLTE.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        public SidebarViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            //you can do the access rights checking here by using session, user, and/or filter parameter
            var sidebars = new List<SidebarMenu>();

            //if (((ClaimsPrincipal)User).GetUserProperty("AccessProfile").Contains("VES_008, Payroll"))
            //{
            //}

            sidebars.Add(ModuleHelper.AddHeader("MAIN NAVIGATION"));
            /*sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.Home));
            sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.Reports));
            sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.Outlets));
            sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.Sampling));
            sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.Staff));
            sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.Tasks));*/
            //sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.DisplayMode, Tuple.Create(0, 1, 0))); <--Counter Badge



            if (User.IsInRole("SuperAdmins"))
            {
                sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.Home));
                sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.Outlets));


                sidebars.Add(ModuleHelper.AddTree("Rewards"));
                sidebars.Last().TreeChild = new List<SidebarMenu>()
                {
                    ModuleHelper.AddModule(ModuleHelper.Module.SuperAdmin),
                    //ModuleHelper.AddModule(ModuleHelper.Module.Role),
                };
            }
            else
            {
                sidebars.Add(ModuleHelper.AddModule(ModuleHelper.Module.Reports));


            }

            return View(sidebars);
        }
    }
}
