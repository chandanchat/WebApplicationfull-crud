using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationfull_crud.Models;

namespace WebApplicationfull_crud.Controllers
{
    public class CourceController1 : Controller
    {
        private readonly EmpDbContext _context;
        public CourceController1(EmpDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var Employees = _context.Employees.ToList();
            return View(Employees);
        }
        [HttpGet]
        public IActionResult create() 
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var Employees = _context.Employees.Where(d => d.id == id).FirstOrDefault();
            return View(Employees);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var Employees = _context.Employees.Where(d => d.id == id).FirstOrDefault();
            return View(Employees);
        }
        [HttpGet]
        public IActionResult delete(int id)
        {
            var Employees = _context.Employees.Where(d => d.id == id).FirstOrDefault();
            return View(Employees);
        }
        [HttpPost]
        public IActionResult create(emp Model)
        {
            _context.Employees.Add(Model);
            _context.SaveChanges();
            return RedirectToAction("Indext");
        }
        [HttpPost]
        public IActionResult Edit(emp model)
        {
            _context.Employees.Update( model);
            _context.SaveChanges();
            return RedirectToAction("Indext");
        }
        [HttpPost]
        public IActionResult remove(emp model)
        {
            _context.Employees.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Indext");
        }

    }
}
