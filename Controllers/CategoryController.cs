using ASM1670.Data;
using ASM1670.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ASM1670.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext context;

        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [Authorize(Roles = "Administrator")]
        public IActionResult Index()
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            var categories = context.Categories.ToList();
            return View(categories);
        }
        [Authorize(Roles = "Administrator")]
        public IActionResult Info(int? id)
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            if (id == null)
            {
                return NotFound();
            }
            var categories = context.Categories
                                    .Include(c => c.Books)
                                    .FirstOrDefault(c => c.Id == id);
            //Note: khi muốn truy xuất dữ liệu của bảng B từ bảng A
            //thì cần sử dụng Include kết hợp với FirstOrDefault
            //còn nếu chỉ truy xuất thông tin id đơn thuần thì sử dụng
            //Find hoặc FirstOrDefault đều được
            return View(categories);
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult Add()
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            return View();
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public IActionResult Add(Category category)
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            //kiểm tra thông tin nhập vào từ form
            if (ModelState.IsValid)
            {
                //nếu hợp lệ thì add vào db
                context.Categories.Add(category);
                //lưu thay đổi vào db
                context.SaveChanges();
                //return về trang index
                return RedirectToAction("Index");
                //return RedirectToAction(nameof(Index));
            }
            //nếu không hợp lệ thì quay ngược về form 
            return View(category);
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            var category = context.Categories.Find(id);
            return View(category);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            //load catgory o thanh navbar
            var cate = context.Categories.ToList();
            ViewBag.Categories = cate;
            if (ModelState.IsValid)
            {
                //nếu hợp lệ thì cập nhật vào db
                context.Categories.Update(category);
                //lưu thay đổi vào db
                context.SaveChanges();
                //return về trang index
                return RedirectToAction("Index");
                //return RedirectToAction(nameof(Index));
            }
            //nếu không hợp lệ thì quay ngược về form 
            return View(category);
        }
    }
}
