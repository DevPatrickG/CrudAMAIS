using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUDAppAMAIS.Models;


namespace CRUDAppAMAIS.Controllers 
{
    public class StudentsAndController : Controller
    {
        private readonly Contexto _context;

        public StudentsAndController(Contexto context)
        {
            _context = context;
        }

        // GET: StudentsAnd
        public async Task<IActionResult> Index()
        {
              return _context.Student != null ? 
                          View(await _context.Student.ToListAsync()) :
                          Problem("Entity set 'Contexto.Student'  is null.");
        }

        // GET: StudentsAnd/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.RA == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: StudentsAnd/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentsAnd/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RA,Nome,Email,Cpf")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                TempData["Sweet"] = "";              
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
               
            }
            return View(student);
        }

        // GET: StudentsAnd/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: StudentsAnd/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("RA,Nome,Email,Cpf")] Student student)
        {
            if (id != student.RA)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.RA))
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
            return View(student);
        }

        // GET: StudentsAnd/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.RA == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: StudentsAnd/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Student == null)
            {
                return Problem("Entity set 'Contexto.Student'  is null.");
            }
            var student = await _context.Student.FindAsync(id);
            if (student != null)
            {
                _context.Student.Remove(student);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(string id)
        {
          return (_context.Student?.Any(e => e.RA == id)).GetValueOrDefault();
        }
    }
}
