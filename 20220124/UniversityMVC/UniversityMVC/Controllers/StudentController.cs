using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UniversityMVC.Models;

namespace UniversityMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly UniversityContext _db;

        public StudentController(UniversityContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Students.ToList());
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(Student student) //Model Binding: Form aracılığıyla gelen verilerin belirtilen modelin                                                                     property'sine aktarılması.
        {
            if (ModelState.IsValid)
            {
                _db.Add(student);
                _db.SaveChanges();
                return RedirectToAction("Index", "Student");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            Student student = _db.Students.FirstOrDefault(x => x.Id == id);
            if (student == null) return NotFound();
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _db.Update(student);
                _db.SaveChanges();
                return RedirectToAction("Index", "Student");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            Student student = _db.Students.FirstOrDefault(x => x.Id == id);
            if (student == null) return NotFound();
            return View(student);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Student student = _db.Students.FirstOrDefault(x => x.Id == id);
            if (student == null) return NotFound();
            _db.Remove(student);
            _db.SaveChanges();
            return RedirectToAction("Index", "Student");
        }
    }
}
