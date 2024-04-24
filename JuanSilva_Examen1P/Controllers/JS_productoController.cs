using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JuanSilva_Examen1P.Data;
using JuanSilva_Examen1P.Models;

namespace JuanSilva_Examen1P.Controllers
{
    public class JS_productoController : Controller
    {
        private readonly JuanSilva_Examen1PContext _context;

        public JS_productoController(JuanSilva_Examen1PContext context)
        {
            _context = context;
        }

        // GET: JS_producto
        public async Task<IActionResult> Index()
        {
            return View(await _context.JS_producto.ToListAsync());
        }

        // GET: JS_producto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jS_producto = await _context.JS_producto
                .FirstOrDefaultAsync(m => m.JsProductoID == id);
            if (jS_producto == null)
            {
                return NotFound();
            }

            return View(jS_producto);
        }

        // GET: JS_producto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JS_producto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JsProductoID,JsnumeroSerie,Jsprecio,JsNombreProducto,JsDisponible,JsFechaAgregado")] JS_producto jS_producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jS_producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jS_producto);
        }

        // GET: JS_producto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jS_producto = await _context.JS_producto.FindAsync(id);
            if (jS_producto == null)
            {
                return NotFound();
            }
            return View(jS_producto);
        }

        // POST: JS_producto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JsProductoID,JsnumeroSerie,Jsprecio,JsNombreProducto,JsDisponible,JsFechaAgregado")] JS_producto jS_producto)
        {
            if (id != jS_producto.JsProductoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jS_producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JS_productoExists(jS_producto.JsProductoID))
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
            return View(jS_producto);
        }

        // GET: JS_producto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jS_producto = await _context.JS_producto
                .FirstOrDefaultAsync(m => m.JsProductoID == id);
            if (jS_producto == null)
            {
                return NotFound();
            }

            return View(jS_producto);
        }

        // POST: JS_producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jS_producto = await _context.JS_producto.FindAsync(id);
            if (jS_producto != null)
            {
                _context.JS_producto.Remove(jS_producto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JS_productoExists(int id)
        {
            return _context.JS_producto.Any(e => e.JsProductoID == id);
        }
    }
}
