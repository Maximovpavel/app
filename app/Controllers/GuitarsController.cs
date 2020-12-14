using app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Controllers
{
    public class GuitarsController : Controller
    {
        AppDbContext db;
        public GuitarsController(AppDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Guitars.ToList());
        }

        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.GuitarId = id;
            return View();
        }
        [HttpPost]
        public IActionResult Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            ViewBag.User = order.User;
            return View("Views/Guitars/OrderFinished.cshtml");
        }
        public IActionResult AddNewGuitar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNewGuitar(Guitar guitar)
        {
            db.Guitars.Add(guitar);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Guitar guitar = await db.Guitars.FirstOrDefaultAsync(p => p.Id == id);
                if (guitar != null)
                    return View(guitar);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Guitar guitar)
        {
            db.Guitars.Update(guitar);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Guitar guitar = await db.Guitars.FirstOrDefaultAsync(p => p.Id == id);
                if (guitar != null)
                    return View(guitar);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Guitar user = await db.Guitars.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                {
                    db.Guitars.Remove(user);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

    }
}
