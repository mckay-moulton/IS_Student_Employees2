using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IS_Student_Employees2.Data;
using IS_Student_Employees2.Models;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Security;

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
        //Only return current TA's
        public IActionResult TAs()
        {
            var ta = _context.Employee.Where(s => s.Position_Type == "TA" && s.Terminated == false).
                ToList();
            return View(ta);
        }
        //Only return current RA's
        public IActionResult RAs()
        {
            var ta = _context.Employee.Where(s => s.Position_Type == "RA" && s.Terminated == false).
                ToList();
            return View(ta);
        }
        //testing order by year, group by semester
        public IActionResult test()
        {
            var q = _context.Employee.OrderByDescending(s => s.Year).ThenBy(s => s.Semester).
                //GroupBy(s => s.Semester).
                ToList();
            return View(q);
        }
        // email stuff ____________________________________________________________________________
        public ActionResult SendEmail()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendEmail(string receiver, string subject, string a_message)
        {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Jack Witherspoon", "thisisagreatbigtest@outlook.com"));
                message.To.Add(new MailboxAddress("Mrs. Chanandler Bong", receiver));
                message.Subject = subject;

                message.Body = new TextPart("plain")
                {
                    Text = "Hello! This is a default message that McKay wrote. A url could go here, or maybe not!"
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate("thisisagreatbigtest@outlook.com", "theBagelBoy67");

                    client.Send(message);
                    client.Disconnect(true);
                }
                return RedirectToAction("Index");
            }


        }
    }
