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
    public class FacultyMembersController : Controller
    {
        private readonly MyDbContext _context;

        public FacultyMembersController(MyDbContext context)
        {
            _context = context;
        }

        // GET: FacultyMembers
        public async Task<IActionResult> Index()
        {
            return View(await _context.MembrosFaculdade.ToListAsync());
        }

        // GET: FacultyMembers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facultyMember = await _context.MembrosFaculdade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (facultyMember == null)
            {
                return NotFound();
            }

            return View(facultyMember);
        }

        // GET: FacultyMembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FacultyMembers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("fName,facultyColl,Id,mName,mAddress,mNo")] FacultyMember facultyMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(facultyMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(facultyMember);
        }

        // GET: FacultyMembers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facultyMember = await _context.MembrosFaculdade.FindAsync(id);
            if (facultyMember == null)
            {
                return NotFound();
            }
            return View(facultyMember);
        }

        // POST: FacultyMembers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("fName,facultyColl,Id,mName,mAddress,mNo")] FacultyMember facultyMember)
        {
            if (id != facultyMember.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(facultyMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacultyMemberExists(facultyMember.Id))
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
            return View(facultyMember);
        }

        // GET: FacultyMembers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facultyMember = await _context.MembrosFaculdade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (facultyMember == null)
            {
                return NotFound();
            }

            return View(facultyMember);
        }

        // POST: FacultyMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var facultyMember = await _context.MembrosFaculdade.FindAsync(id);
            _context.MembrosFaculdade.Remove(facultyMember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FacultyMemberExists(int id)
        {
            return _context.MembrosFaculdade.Any(e => e.Id == id);
        }
    }
}
