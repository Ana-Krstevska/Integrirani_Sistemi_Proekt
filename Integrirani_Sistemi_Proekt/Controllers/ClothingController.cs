using Integrirani_Sistemi_Proekt.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Controllers
{
    public class ClothingController : Controller
    {
        private readonly AppDbContext _context;

        public ClothingController(AppDbContext context)
        {
            _context = context;
        }
        
        // GET: ClothingController
        public ActionResult Index()
        {
            var data = _context.Clothing.ToList();
            // TODO ovde se vrakja soodveten view
            return View();
        }

        // GET: ClothingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClothingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClothingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClothingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClothingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClothingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClothingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
