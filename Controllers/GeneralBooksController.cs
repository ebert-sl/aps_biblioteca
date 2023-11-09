#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using biblioteca.Models;

namespace biblioteca.Controllers
{
    public class GeneralBooksController : Controller
    {
        private readonly MyDbContext _context;

        public GeneralBooksController(MyDbContext context)
        {
            _context = context;
        }

        // GET: GeneralBooks
        public async Task<IActionResult> Index()
        {
            return View(await _context.LivrosGenericos.ToListAsync());
        }

        // GET: GeneralBooks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalBook = await _context.LivrosGenericos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generalBook == null)
            {
                return NotFound();
            }

            return View(generalBook);
        }

        // GET: GeneralBooks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GeneralBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,bookName,authorName,noOfBooks")] GeneralBook generalBook)
        {
            if (ModelState.IsValid)
            {
                _context.Add(generalBook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(generalBook);
        }

        // GET: GeneralBooks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalBook = await _context.LivrosGenericos.FindAsync(id);
            if (generalBook == null)
            {
                return NotFound();
            }
            return View(generalBook);
        }

        // POST: GeneralBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,bookName,authorName,noOfBooks")] GeneralBook generalBook)
        {
            if (id != generalBook.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(generalBook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneralBookExists(generalBook.Id))
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
            return View(generalBook);
        }

        // GET: GeneralBooks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalBook = await _context.LivrosGenericos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generalBook == null)
            {
                return NotFound();
            }

            return View(generalBook);
        }

        // POST: GeneralBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var generalBook = await _context.LivrosGenericos.FindAsync(id);
            _context.LivrosGenericos.Remove(generalBook);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneralBookExists(int id)
        {
            return _context.LivrosGenericos.Any(e => e.Id == id);
        }
    }
}
