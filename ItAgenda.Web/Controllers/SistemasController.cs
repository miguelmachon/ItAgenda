﻿using System;
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
    public class SistemasController : Controller
    {
        private readonly DataContext _context;

        public SistemasController(DataContext context)
        {
            _context = context;
        }

        // GET: Sistemas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sistemas.ToListAsync());
        }

        // GET: Sistemas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sistema = await _context.Sistemas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sistema == null)
            {
                return NotFound();
            }

            return View(sistema);
        }

        // GET: Sistemas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sistemas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Sistema sistema)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sistema);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sistema);
        }

        // GET: Sistemas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sistema = await _context.Sistemas.FindAsync(id);
            if (sistema == null)
            {
                return NotFound();
            }
            return View(sistema);
        }

        // POST: Sistemas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Sistema sistema)
        {
            if (id != sistema.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sistema);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SistemaExists(sistema.Id))
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
            return View(sistema);
        }

        // GET: Sistemas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sistema = await _context.Sistemas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sistema == null)
            {
                return NotFound();
            }

            return View(sistema);
        }

        // POST: Sistemas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sistema = await _context.Sistemas.FindAsync(id);
            _context.Sistemas.Remove(sistema);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SistemaExists(int id)
        {
            return _context.Sistemas.Any(e => e.Id == id);
        }
    }
}
