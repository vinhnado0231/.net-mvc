using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTHDV.StudentMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace KTHDV.StudentMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly DataContext _context;
        public StudentController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Save(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}