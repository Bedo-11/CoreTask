using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Helpers;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Authorize]
    public class ReportzsController : Controller
    {
        
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _environment;
      //ivate readonly UserManager<ApplicationUser> _userManager;
        private readonly UserManager<IdentityUser> _userManager;


        public ReportzsController(ApplicationDbContext context, IHostingEnvironment environment , UserManager<IdentityUser> userManager)
        {
            _context = context;
            _environment = environment;
            _userManager = userManager; 
        }

        // GET: Reportzs
        public async Task<IActionResult> Index()
        {
            var currentUser = _userManager.GetUserId(User);
            var applicationDbContext = _context.Reportz.Include(r => r.Statuez).Where(r => r.UserId == currentUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Reportzs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportz = await _context.Reportz
                .Include(r => r.Statuez)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reportz == null)
            {
                return NotFound();
            }

            return View(reportz);
        }

        // GET: Reportzs/Create
        public IActionResult Create()
        {
            ViewData["StatuezId"] = new SelectList(_context.Statuez, "Id", "Name");
            ViewData["UserId"] = new SelectList(_context.ApplicationUser, "Id", "Id");
            return View();
        }

        // POST: Reportzs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StatuezId,Topicz,Textz,ImageUrl")] Reportz reportz, IFormFile myfile)
        {
            if (ModelState.IsValid)
            {
                reportz.ImageUrl = await UserFile.UploadeNewImageAsync(reportz.ImageUrl,
              myfile, _environment.WebRootPath, Properties.Resources.ImgFolder, 100, 100);

                reportz.UserId = _userManager.GetUserId(User); 

                _context.Add(reportz);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatuezId"] = new SelectList(_context.Statuez, "Id", "Name", reportz.StatuezId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", reportz.UserId);
            return View(reportz);
        }

        // GET: Reportzs/Edit/5
       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportz = await _context.Reportz.FindAsync(id);
            if (reportz == null)
            {
                return NotFound();
            }
            ViewData["StatuezId"] = new SelectList(_context.Statuez, "Id", "Name", reportz.StatuezId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", reportz.UserId);
            return View(reportz);
        }

        // POST: Reportzs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        //[Authorize(Roles = "Manager")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Edit(int id, [Bind("Id,StatuezId,Topicz,Textz,ImageUrl")] Reportz reportz)
        {
            if (id != reportz.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportz);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportzExists(reportz.Id))
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
            ViewData["StatuezId"] = new SelectList(_context.Statuez, "Id", "Name", reportz.StatuezId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", reportz.UserId);
            return View(reportz);
        }

        // GET: Reportzs/Delete/5
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportz = await _context.Reportz
                .Include(r => r.Statuez)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reportz == null)
            {
                return NotFound();
            }

            return View(reportz);
        }

        // POST: Reportzs/Delete/5
        //[Authorize(Roles="Manager")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportz = await _context.Reportz.FindAsync(id);
            _context.Reportz.Remove(reportz);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportzExists(int id)
        {
            return _context.Reportz.Any(e => e.Id == id);
        }
    }
}
