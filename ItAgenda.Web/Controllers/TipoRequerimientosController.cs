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
    public class TipoRequerimientosController : Controller
    {
        private readonly DataContext _context;

        public TipoRequerimientosController(DataContext context)
        {
            _context = context;
        }

        // GET: TipoRequerimientos
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoRequerimientos.ToListAsync());
        }

        // GET: TipoRequerimientos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoRequerimiento = await _context.TipoRequerimientos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoRequerimiento == null)
            {
                return NotFound();
            }

            return View(tipoRequerimiento);
        }

        // GET: TipoRequerimientos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoRequerimientos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoRequerimiento tipoRequerimiento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoRequerimiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoRequerimiento);
        }

        // GET: TipoRequerimientos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoRequerimiento = await _context.TipoRequerimientos.FindAsync(id);
            if (tipoRequerimiento == null)
            {
                return NotFound();
            }
            return View(tipoRequerimiento);
        }

        // POST: TipoRequerimientos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoRequerimiento tipoRequerimiento)
        {
            if (id != tipoRequerimiento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoRequerimiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoRequerimientoExists(tipoRequerimiento.Id))
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
            return View(tipoRequerimiento);
        }

        // GET: TipoRequerimientos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoRequerimiento = await _context.TipoRequerimientos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoRequerimiento == null)
            {
                return NotFound();
            }

            return View(tipoRequerimiento);
        }

        // POST: TipoRequerimientos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoRequerimiento = await _context.TipoRequerimientos.FindAsync(id);
            _context.TipoRequerimientos.Remove(tipoRequerimiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoRequerimientoExists(int id)
        {
            return _context.TipoRequerimientos.Any(e => e.Id == id);
        }
    }
}
