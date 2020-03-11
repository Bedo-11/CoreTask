using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Authorize]
    public class StatuezsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StatuezsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Statuezs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Statuez.ToListAsync());
        }

        // GET: Statuezs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statuez = await _context.Statuez
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statuez == null)
            {
                return NotFound();
            }

            return View(statuez);
        }

        // GET: Statuezs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Statuezs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,description")] Statuez statuez)
        {
            if (ModelState.IsValid)
            {
                _context.Add(statuez);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(statuez);
        }

        // GET: Statuezs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statuez = await _context.Statuez.FindAsync(id);
            if (statuez == null)
            {
                return NotFound();
            }
            return View(statuez);
        }

        // POST: Statuezs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,description")] Statuez statuez)
        {
            if (id != statuez.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(statuez);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatuezExists(statuez.Id))
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
            return View(statuez);
        }

        // GET: Statuezs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statuez = await _context.Statuez
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statuez == null)
            {
                return NotFound();
            }

            return View(statuez);
        }

        // POST: Statuezs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var statuez = await _context.Statuez.FindAsync(id);
            _context.Statuez.Remove(statuez);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatuezExists(int id)
        {
            return _context.Statuez.Any(e => e.Id == id);
        }
    }
}
