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
    public class EmployeesController : Controller
    {
        private readonly IS_Student_Employees2Context _context;

        public EmployeesController(IS_Student_Employees2Context context)
        {
            _context = context;
        }

    //OG Index 
        //public async Task<IActionResult> Index()
        //{

        //      return View(await _context.Employee.ToListAsync());
        //}
        // GET: Employees
        //Index w/Search 

        public async Task<IActionResult> Index(string searchString)
        {
            //order by year and semester
            var employees = from m in _context.Employee.OrderByDescending(s => s.Year).ThenBy(s => s.Semester)
                            select m;
            //var employees = _context.Employee.OrderByDescending(s => s.Year).ThenBy(s => s.Semester)

            //if the search bar is not empty, perform LINQ Filter, redirecting to same Index Page
            //First filter is for last name

            if (!String.IsNullOrEmpty(searchString))
            {
                employees = employees.Where(s => s.Stud_Last!.Contains(searchString)).OrderByDescending(s => s.Year).ThenBy(s => s.Semester); 
            }

            return View(await employees.ToListAsync());
        }

        //Create Supervisor View based off of INDEX
        public async Task<IActionResult> SupervisorView(string searchString)
        {
            var employees = from m in _context.Employee.OrderByDescending(s => s.Year).ThenBy(s => s.Semester)
                            select m;
            //if the search bar is not empty, perform LINQ Filter, redirecting to same Index Page
            //First filter is for last name

            if (!String.IsNullOrEmpty(searchString))
            {
                employees = employees.Where(s => s.Supervisor!.Contains(searchString)).OrderByDescending(s => s.Year).ThenBy(s => s.Semester);
            }

            return View(await employees.ToListAsync());
        }

        //Create Year View filter View
        public async Task<IActionResult> YearView(int searchString)
        {
            var employees = from m in _context.Employee.OrderByDescending(s => s.Year).ThenBy(s => s.Semester)
                            select m;
            //if the search bar is not empty, perform LINQ Filter, redirecting to same Index Page
            //First filter is for last name


            if (searchString != 0 )
            {
                employees = employees.Where(s => s.Year == searchString).OrderByDescending(s => s.Year).ThenBy(s => s.Semester);
            }



            return View(await employees.ToListAsync());
        }


        // Employees Details 
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Employee == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Stud_First,Stud_Last,BYUID,International,Gender,Email,Exp_Hours,Semester,Year,Phone,Position_Type,Class_Code,Empl_Record,Supervisor,Hire_Date,Pay_Rate,Last_Pay_Increase,Increase_Input_Date,Pay_Increase_Amount,Year_In_Program,Pay_Grad_Tuition,Name_Change_Complete,Notes,Terminated,Termination_Date,Qualtrics_Survey_Sent,Submitted_Form,Form_Submission_Date,Authorization_To_Work_Received,Authorization_To_Work_Email_Sent_Date,BYU_Name")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Employee == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Stud_First,Stud_Last,BYUID,International,Gender,Email,Exp_Hours,Semester,Year,Phone,Position_Type,Class_Code,Empl_Record,Supervisor,Hire_Date,Pay_Rate,Last_Pay_Increase,Increase_Input_Date,Pay_Increase_Amount,Year_In_Program,Pay_Grad_Tuition,Name_Change_Complete,Notes,Terminated,Termination_Date,Qualtrics_Survey_Sent,Submitted_Form,Form_Submission_Date,Authorization_To_Work_Received,Authorization_To_Work_Email_Sent_Date,BYU_Name")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Employee == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Employee == null)
            {
                return Problem("Entity set 'IS_Student_Employees2Context.Employee'  is null.");
            }
            var employee = await _context.Employee.FindAsync(id);
            if (employee != null)
            {
                _context.Employee.Remove(employee);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
          return _context.Employee.Any(e => e.Id == id);
        }
    }
}
