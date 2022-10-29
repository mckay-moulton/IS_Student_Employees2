﻿using System;
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
    public class Employees1Controller : Controller
    {
        private readonly IS_Student_Employees2Context _context;

        public Employees1Controller(IS_Student_Employees2Context context)
        {
            _context = context;
        }

        // GET: Employees1
        public async Task<IActionResult> Index()
        {
              return View(await _context.Employee.ToListAsync());
        }

        // GET: Employees1/Details/5
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

        // GET: Employees1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees1/Create
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

        // GET: Employees1/Edit/5
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

        // POST: Employees1/Edit/5
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

        // GET: Employees1/Delete/5
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

        // POST: Employees1/Delete/5
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
