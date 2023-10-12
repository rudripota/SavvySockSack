using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SavvySockSack.Data;
using SavvySockSack.Models;

namespace SavvySockSack.Controllers
{
    public class SocksController : Controller
    {
        private readonly MvcSocksContext _context;

        public SocksController(MvcSocksContext context)
        {
            _context = context;
        }

        // GET: Socks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Socks.ToListAsync());
        }

        // GET: Socks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socks = await _context.Socks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socks == null)
            {
                return NotFound();
            }

            return View(socks);
        }

        // GET: Socks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Socks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Size,Material,Pattern,Price")] MvcSocksContext socks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(socks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(socks);
        }

        // GET: Socks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socks = await _context.Socks.FindAsync(id);
            if (socks == null)
            {
                return NotFound();
            }
            return View(socks);
        }

        // POST: Socks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        /*public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Size,Material,Pattern,Price")] MvcSocksContext socks)
        {
            if (id == socks.Id)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(socks);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!SocksExists(socks.Id))
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
                return View(socks);
            }
            return NotFound();
        }*/

        private bool SocksExists(object id)
        {
            throw new NotImplementedException();
        }

        // GET: Socks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socks = await _context.Socks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socks == null)
            {
                return NotFound();
            }

            return View(socks);
        }

        // POST: Socks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var socks = await _context.Socks.FindAsync(id);
            _context.Socks.Remove(socks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SocksExists(int id)
        {
            return _context.Socks.Any(e => e.Id == id);
        }
    }
}
