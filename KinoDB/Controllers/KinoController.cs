using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoDB.Controllers
{
    public class KinoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
