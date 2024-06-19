using MedicineApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedicineApp.Controllers
{
    public class MedicineController : Controller
    {
        private readonly MedicineContext _context;

        public MedicineController(MedicineContext context)
        {
            _context = context;
        }

        public IActionResult Medicines()
        {
            var medicines = _context.Medicines.ToList();
            return View(medicines);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Medicine medicine)
        {
           if (ModelState.IsValid)
           {
               _context.Medicines.Add(medicine);
               _context.SaveChanges();
               return RedirectToAction("Medicines");
           }

               return View(medicine);
        }
        public IActionResult Edit(int id)
        {
            var medicine = _context.Medicines.Find(id);
            if (medicine == null)
            {
                return NotFound();
            }

            return View(medicine);
        }

        [HttpPost]
        public IActionResult Edit(Medicine medicine)
        {
            if (ModelState.IsValid)
            {
                _context.Update(medicine);
                _context.SaveChanges();
                return RedirectToAction("Medicines"); 
            }

            return View(medicine);
        }

        public IActionResult Details(int id)
        {
            var medicine = _context.Medicines.Find(id);
            if (medicine == null)
            {
                return NotFound();
            }

            return View(medicine);
        }

    }
}
