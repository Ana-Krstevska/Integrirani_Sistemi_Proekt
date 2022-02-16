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
    public class ClothingsController : Controller
    {
        private readonly IClothingsService _service;

        public ClothingsController(IClothingsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Clothings/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Description,Price,ImageUrl,StartDate,EndDate,AmountXS,AmountS,AmountM,AmoutnL,AmountXL,BrandId,ShopId")] Clothing clothing)
        {
            if (!ModelState.IsValid)
            {
                return View(clothing);
            }

            await _service.AddAsync(clothing);
            return RedirectToAction(nameof(Index));
        }

        //Get: Clothings/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var clothingDetails = await _service.GetByIdAsync(id);

            if (clothingDetails == null)
                return View("NotFound");
            return View(clothingDetails);
        }

        //Get: Clothings/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var brandDetails = await _service.GetByIdAsync(id);

            if (brandDetails == null)
                return View("NotFound");
            return View(brandDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Price,ImageUrl,StartDate,EndDate,AmountXS,AmountS,AmountM,AmoutnL,AmountXL,BrandId,ShopId")] Clothing clothing)
        {
            if (!ModelState.IsValid)
            {
                return View(clothing); ;
            }

            await _service.UpdateAsync(id, clothing); ;
            return RedirectToAction(nameof(Index));
        }

        //Get: Clothings/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var clothingDetails = await _service.GetByIdAsync(id);

            if (clothingDetails == null)
                return View("NotFound");
            return View(clothingDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clothingDetails = await _service.GetByIdAsync(id);

            if (clothingDetails == null)
                return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
