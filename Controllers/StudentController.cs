using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DNC6.Data;

namespace DNC6.Controllers
{
    [Route("[controller]/[action]")]
    public class StudentController : Controller
    {
        ApplicationDbContext _dbContext;
        
        public StudentController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            ModelState.Remove("StudentId");
            if (ModelState.IsValid)
            {
                _dbContext.Students.Add(model);
                _dbContext.SaveChanges();
                TempData["StatusMessage"] = "Your profile has been updated";
                //return RedirectToAction("Index");
            }
            return View();
        }



    }
}