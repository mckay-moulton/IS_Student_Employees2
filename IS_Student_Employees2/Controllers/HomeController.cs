using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IS_Student_Employees2.Data;
using IS_Student_Employees2.Models;

namespace IS_Student_Employees2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IS_Student_Employees2Context _context;

        public HomeController(IS_Student_Employees2Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TAs()
        {
            var ta = _context.Employee.Where(s => s.Position_Type == "TA").
                ToList();
            return View(ta);
        }

    }
}