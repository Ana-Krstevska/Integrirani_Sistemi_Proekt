using Integrirani_Sistemi_Proekt.Data;
using Integrirani_Sistemi_Proekt.Data.Services;
using Integrirani_Sistemi_Proekt.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Controllers
{
    public class TagsController : Controller
    {
        private readonly ITagsService _service;

        public TagsController(ITagsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Tags/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Season,ClothingPiece,Fabric")]Tag tag)
        {
            if(!ModelState.IsValid)
            {
                return View(tag);
            }

            await _service.AddAsync(tag);
            return RedirectToAction(nameof(Index));
        }

        //Get: Tags/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var tagDetails = await _service.GetByIdAsync(id);

            if (tagDetails == null)
                return View("NotFound");
            return View(tagDetails);
        }

        //Get: Tags/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var tagDetails = await _service.GetByIdAsync(id);

            if (tagDetails == null)
                return View("NotFound");
            return View(tagDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Season,ClothingPiece,Fabric")] Tag tag)
        {
            if (!ModelState.IsValid)
            {
                return View(tag);
            }

            await _service.UpdateAsync(id,tag);
            return RedirectToAction(nameof(Index));
        }

        //Get: Tags/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var tagDetails = await _service.GetByIdAsync(id);

            if (tagDetails == null)
                return View("NotFound");
            return View(tagDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tagDetails = await _service.GetByIdAsync(id);

            if (tagDetails == null)
                return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
