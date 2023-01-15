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
            var kino = kinoManager.GetKinos();
            return View(kino);
        }
        [HttpGet]

        public IActionResult Add()
        {
            return View(); 
        }

        [HttpPost]

        public IActionResult Add(KinoModel kinoModel)
        {
            kinoManager.AddKino(kinoModel);
            return RedirectToAction("Index");
        }
        [HttpGet]

        public IActionResult Remove(int id)
        {
            var kino = kinoManager.GetKino(id); 
            return View(kino);
        }

        [HttpPost]

        public IActionResult RemoveConfirm(int id)
        {
            kinoManager.RemoveKino(id);
            return RedirectToAction("Index");
        }
        [HttpGet]

        public IActionResult Edit(int id)
        {
            var kino = kinoManager.GetKino(id);
            return View(kino);
        }

        [HttpPost]

        public IActionResult Edit(KinoModel kino)
        {
            kinoManager.UpdateKino(kino);
            return RedirectToAction("Index");
        }
    }
}
