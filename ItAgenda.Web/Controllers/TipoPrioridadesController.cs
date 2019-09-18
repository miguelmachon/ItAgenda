using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ItAgenda.Web.Data;
using ItAgenda.Web.Data.Entities;

namespace ItAgenda.Web.Controllers
{
    public class TipoPrioridadesController : Controller
    {
        private readonly DataContext _context;

        public TipoPrioridadesController(DataContext context)
        {
            _context = context;
        }

        // GET: TipoPrioridades
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoPrioridades.ToListAsync());
        }

        // GET: TipoPrioridades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPrioridad = await _context.TipoPrioridades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoPrioridad == null)
            {
                return NotFound();
            }

            return View(tipoPrioridad);
        }

        // GET: TipoPrioridades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoPrioridades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoPrioridad tipoPrioridad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoPrioridad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoPrioridad);
        }

        // GET: TipoPrioridades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPrioridad = await _context.TipoPrioridades.FindAsync(id);
            if (tipoPrioridad == null)
            {
                return NotFound();
            }
            return View(tipoPrioridad);
        }

        // POST: TipoPrioridades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoPrioridad tipoPrioridad)
        {
            if (id != tipoPrioridad.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoPrioridad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoPrioridadExists(tipoPrioridad.Id))
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
            return View(tipoPrioridad);
        }

        // GET: TipoPrioridades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPrioridad = await _context.TipoPrioridades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoPrioridad == null)
            {
                return NotFound();
            }

            return View(tipoPrioridad);
        }

        // POST: TipoPrioridades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoPrioridad = await _context.TipoPrioridades.FindAsync(id);
            _context.TipoPrioridades.Remove(tipoPrioridad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoPrioridadExists(int id)
        {
            return _context.TipoPrioridades.Any(e => e.Id == id);
        }
    }
}
