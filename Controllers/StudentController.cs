using Microsoft.AspNetCore.Mvc;
using Abilong_ELENET1.MVC.Data;
using Abilong_ELENET1.MVC.Models;

namespace Abilong_ELENET1.MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Students.ToList();
            return View(data);
        }

      
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(s);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(s);
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
           
            var student = _context.Students.Find(id);

            if (student != null)
            {
                
                _context.Students.Remove(student);
                _context.SaveChanges();
            }

           
            return RedirectToAction("Index");
        }
    }
}