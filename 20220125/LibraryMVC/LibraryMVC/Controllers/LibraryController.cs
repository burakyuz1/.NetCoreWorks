using LibraryMVC.Models;
using LibraryMVC.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LibraryMVC.Controllers
{
    public class LibraryController : Controller
    {
        private readonly LibraryContext _context;

        public LibraryController(LibraryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Book> model = _context.Books.ToList();
            return View(model);
        }


        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                _context.SaveChanges();
                return RedirectToAction("Index", "Library");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            Book updatedBook = _context.Books.Find(id);
            if (updatedBook == null) return NotFound();
            return View(updatedBook);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Update(book);
                _context.SaveChanges();
                return RedirectToAction("Index", "Library");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            Book deletedBook = _context.Books.Find(id);
            if (deletedBook == null) return NotFound();
            return View(deletedBook);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Book deletedBook = _context.Books.Find(id);
            if (deletedBook == null) return NotFound();
            _context.Remove(deletedBook);
            _context.SaveChanges();

            return RedirectToAction("Index", "Library");

        }

    }
}
