using AdminLTE.Models;
using System;
using System.Collections.Generic;

namespace AdminLTE.Common
{
    /// <summary>
    /// This is where you customize the navigation sidebar
    /// </summary>
    public static class ModuleHelper
    {
        public enum Module
        {
            Home,
            Reports,
            Outlets,
            Sampling,
            Staff,
            Tasks,
            SuperAdmin,
            Role,
        }

        public static SidebarMenu AddHeader(string name)
        {
            return new SidebarMenu
            {
                Type = SidebarMenuType.Header,
                Name = name,
            };
        }

        public static SidebarMenu AddTree(string name, string iconClassName = "fa fa-cogs")
        {
            return new SidebarMenu
            {
                Type = SidebarMenuType.Tree,
                IsActive = false,
                Name = name,
                IconClassName = iconClassName,
                URLPath = "#",
            };
        }

        public static SidebarMenu AddModule(Module module, Tuple<int, int, int> counter = null)
        {
            if (counter == null)
                counter = Tuple.Create(0, 0, 0);

            switch (module)
            {
                case Module.Home:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Dashboard",
                        IconClassName = "fa fa-dashboard",
                        URLPath = "/",
                        LinkCounter = counter,
                    };
                case Module.Reports:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Reports",
                        IconClassName = "fa fa-clipboard",
                        URLPath = "/Reports",
                        LinkCounter = counter,
                    };
                case Module.Outlets:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Outlets",
                        IconClassName = "fa fa-building",
                        URLPath = "/Outlets",
                        LinkCounter = counter,
                    };
                case Module.Sampling:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Sampling & Sales",
                        IconClassName = "fa fa-edit",
                        URLPath = "/Sampling",
                        LinkCounter = counter,
                    };
                case Module.Staff:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Staff",
                        IconClassName = "fa fa-users",
                        URLPath = "/Staffs",
                        LinkCounter = counter,
                    };
                case Module.Tasks:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Tasks",
                        IconClassName = "fa fa-tasks",
                        URLPath = "/Tasks",
                        LinkCounter = counter,
                    };
                case Module.SuperAdmin:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "User",
                        IconClassName = "fa fa-link",
                        URLPath = "/SuperAdmin",
                        LinkCounter = counter,
                    };
                case Module.Role:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Role",
                        IconClassName = "fa fa-link",
                        URLPath = "/Role",
                        LinkCounter = counter,
                    };
                default:
                    break;
            }

            return null;
        }
    }
}
