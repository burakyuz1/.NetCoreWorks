using Microsoft.AspNetCore.Mvc;
using SchoolMVC.Models;

namespace SchoolMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly SchoolDbContext _dbContext;

        public StudentController(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(string name, string surname)
        {
            _dbContext.Students.Add(new Student() {Name = name, Surname = surname});
            _dbContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}