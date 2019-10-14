using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GYM.CoreApp.WebUI.Data;
using GYM.CoreApp.WebUI.Models;

namespace GYM.CoreApp.WebUI.Areas.Utilities.Controllers
{
    [Area("Utilities")]
    [Route("Utilities/[controller]/[action]")]
    public class UtilitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UtilitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Utilities/Utilities
        public async Task<IActionResult> Index()
        {
            return View(await _context.Utilities.ToListAsync());
        }

        // GET: Utilities/Utilities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utility = await _context.Utilities
                .FirstOrDefaultAsync(m => m.UtilityId == id);
            if (utility == null)
            {
                return NotFound();
            }

            return View(utility);
        }

        // GET: Utilities/Utilities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Utilities/Utilities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UtilityId,Name")] Utility utility)
        {
            if (ModelState.IsValid)
            {
                _context.Add(utility);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(utility);
        }

        // GET: Utilities/Utilities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utility = await _context.Utilities.FindAsync(id);
            if (utility == null)
            {
                return NotFound();
            }
            return View(utility);
        }

        // POST: Utilities/Utilities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UtilityId,Name")] Utility utility)
        {
            if (id != utility.UtilityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(utility);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UtilityExists(utility.UtilityId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(utility);
        }

        // GET: Utilities/Utilities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utility = await _context.Utilities
                .FirstOrDefaultAsync(m => m.UtilityId == id);
            if (utility == null)
            {
                return NotFound();
            }

            return View(utility);
        }

        // POST: Utilities/Utilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var utility = await _context.Utilities.FindAsync(id);
            _context.Utilities.Remove(utility);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UtilityExists(int id)
        {
            return _context.Utilities.Any(e => e.UtilityId == id);
        }
    }
}
