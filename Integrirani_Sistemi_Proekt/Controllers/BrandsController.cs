using Integrirani_Sistemi_Proekt.Data;
using Integrirani_Sistemi_Proekt.Data.Services;
using Integrirani_Sistemi_Proekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Controllers
{
    public class BrandsController : Controller
    {
        private readonly IBrandsService _service;

        public BrandsController(IBrandsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Brands/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureUrl,Name,Bio")] Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return View(brand);
            }

            await _service.AddAsync(brand);
            return RedirectToAction(nameof(Index));
        }

        //Get: Brands/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var brandDetails = await _service.GetByIdAsync(id);

            if (brandDetails == null)
                return View("NotFound");
            return View(brandDetails);
        }

        //Get: Brands/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var brandDetails = await _service.GetByIdAsync(id);

            if (brandDetails == null)
                return View("NotFound");
            return View(brandDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureUrl,Name,Bio")] Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return View(brand);
            }

            await _service.UpdateAsync(id, brand);
            return RedirectToAction(nameof(Index));
        }

        //Get: Brands/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var brandDetails = await _service.GetByIdAsync(id);

            if (brandDetails == null)
                return View("NotFound");
            return View(brandDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brandDetails = await _service.GetByIdAsync(id);

            if (brandDetails == null)
                return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
