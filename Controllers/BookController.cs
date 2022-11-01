using ASM1670.Data;
using ASM1670.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace ASM1670.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext context;
        public BookController(ApplicationDbContext context)
        {
            this.context = context;
        }
        //view customer
        [Route("/")]
        public IActionResult Index()
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            return View(context.Books.ToList());
        }

        public IActionResult Detail(int id)
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            var book = context.Books
                                 .Include(b => b.Category)
                                 .FirstOrDefault(b => b.Id == id);
            return View(book);
        }
        [Authorize(Roles = "Storeowner")]
        //view admin
        public IActionResult IndexStoreowner()
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            return View(context.Books.ToList());
        }
        public IActionResult Admin()
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            return View(context.Books.ToList());
        }

        [HttpGet]
        public IActionResult Add()
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            var categories = context.Categories.ToList();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            var categories = context.Categories.ToList();
            ViewBag.Categories = categories;
            return View(context.Books.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            if (ModelState.IsValid)
            {
                context.Books.Update(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }
        }

        public IActionResult Delete(int id)
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var book = context.Books.Find(id);
                context.Books.Remove(book);
                context.SaveChanges();
                TempData["Message"] = "Delete successfully";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Search(string keyword)
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            var books = context.Books.Where(b => b.Name.Contains(keyword)).ToList();
            if (books.Count == 0)
            {
                TempData["Message"] = "No book found";
            }
            return View("Index", books);
        }

        //books ma co name co chua keyword chuyen vao giong voi Name trong Database thi se tra lai ra View
        public IActionResult SortASC()
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            return View("Index", context.Books.OrderBy(b => b.Name).ToList());
        }
        public IActionResult SortDSC()
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            return View("Index", context.Books.OrderByDescending(b => b.Name).ToList());
        }
        public IActionResult SortID()
        {
            var book = context.Books.ToList();
            ViewBag.Books = book;
            return View("IndexStoreowner", context.Books.OrderByDescending(b => b.Id).ToList());
        }
        public IActionResult BookbyCate(int?id)
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            var book = context.Books.Where(b => b.CategoryId == id).ToList();
            return View("Index", book);
        }
    }
}
