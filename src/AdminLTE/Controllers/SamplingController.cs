using AdminLTE.Common.Attributes;
using AdminLTE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AdminLTE.Controllers
{
    public class SamplingController : BaseController
    {
        [HelpDefinition]
        public IActionResult Index()
        {
            //AddPageHeader("Dashboard", "");
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
