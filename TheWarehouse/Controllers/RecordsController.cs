using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheWarehouse.Data;
using TheWarehouse.Models;

namespace TheWarehouse.Controllers
{
    public class RecordsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecordsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Records
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Record.Include(c => c.Warehouse);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Records/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Record == null)
            {
                return NotFound();
            }

            var @record = await _context.Record
                .Include(c => c.Warehouse)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@record == null)
            {
                return NotFound();
            }

            return View(@record);
        }

        // GET: Records/Create
        public IActionResult Create()
        {
            ViewData["WarehouseId"] = new SelectList(_context.Set<Warehouse>(), "CompanyId", "CompanyId");
            return View();
        }

        // POST: Records/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,WarehouseId,Date")] Record @record)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@record);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["WarehouseId"] = new SelectList(_context.Set<Warehouse>(), "CompanyId", "CompanyId", @record.WarehouseId);
            return View(@record);
        }

        // GET: Records/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Record == null)
            {
                return NotFound();
            }

            var @record = await _context.Record.FindAsync(id);
            if (@record == null)
            {
                return NotFound();
            }
            ViewData["WarehouseId"] = new SelectList(_context.Set<Warehouse>(), "CompanyId", "CompanyId", @record.WarehouseId);
            return View(@record);
        }

        // POST: Records/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WarehouseId,Date")] Record @record)
        {
            if (id != @record.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@record);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecordExists(@record.Id))
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
            ViewData["WarehouseId"] = new SelectList(_context.Set<Warehouse>(), "CompanyId", "CompanyId", @record.WarehouseId);
            return View(@record);
        }

        // GET: Records/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Record == null)
            {
                return NotFound();
            }

            var @record = await _context.Record
                .Include(c => c.Warehouse)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@record == null)
            {
                return NotFound();
            }

            return View(@record);
        }

        // POST: Records/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Record == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Record'  is null.");
            }
            var @record = await _context.Record.FindAsync(id);
            if (@record != null)
            {
                _context.Record.Remove(@record);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecordExists(int id)
        {
          return _context.Record.Any(e => e.Id == id);
        }
    }
}
