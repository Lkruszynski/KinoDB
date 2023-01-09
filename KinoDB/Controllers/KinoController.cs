using KinoDB.Logic;
using KinoDB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoDB.Controllers
{
    public class KinoController : Controller
    {
        KinoManager kinoManager = new KinoManager();
        public IActionResult Index()
        {
            KinoModel kino = new KinoModel();
            kino.Name = "Cinema City";
            kino.Miejscowosc = "Warszawa"; 
            kino.Ulica = "Wołoska";

            kinoManager.AddKino(kino); 
            return View();
        }
    }
}
