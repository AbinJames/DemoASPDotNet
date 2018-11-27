using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        //Run add-migration 'Migration_Name' in Package Manager Console
        //Run update-database in Package Manager Console
        private readonly StudentContext Context;
        public HomeController(StudentContext context)
        {
            Context = context;
        }
        public IActionResult AllStudents()
        {
            //Query list of students with corresponding batches
            //shows only students with batchid
            ViewData["Students"] = (from s in Context.Student
                                    join b in Context.Batch
                                    on s.batchId equals b.batchId
                                    select new StudentViewModel
                                    {
                                        Id = s.studentId,
                                        Name = s.studentName,
                                        BatchName = b.batchName
                                    })
                                    .ToList();
            //Query list of students with corresponding batches
            //shows all students
            ViewData["LeftOuteredStudents"] = (from s in Context.Student
                                               join b in Context.Batch
                                               on s.batchId equals b.batchId into batch
                                               from b in batch.DefaultIfEmpty()
                                               select new StudentViewModel
                                               {
                                                   Id = s.studentId,
                                                   Name = s.studentName,
                                                   BatchName = b == null ? "(No batch)" : b.batchName
                                               })
                                               .ToList();
            //Querying batches with corresponding students
            //this is groupjoin
            ViewData["GroupStudents"] = (from b in Context.Batch
                                         join s in Context.Student
                                         on b.batchId equals s.batchId
                                         into studentGroup
                                         select new BatchViewModel
                                         {
                                             Id = b.batchId,
                                             student = studentGroup,
                                             batch = b.batchName
                                         })
                                        .ToList();
            //Get list of batches from database
            ViewData["Batch"] = Context.Batch.Distinct().AsNoTracking().ToList();
            return View();
        }

        public IActionResult EditStudent(Guid id)
        {
            ViewBag.id = id;
            //save studentname with corressponding id
            ViewBag.studentName = (from s in Context.Student
                                   where s.studentId == id
                                   select s).First().studentName;
            //save batchid with corressponding id
            ViewBag.batch = (from s in Context.Student
                             where s.studentId == id
                             select s).First().batchId;
            ViewBag.Batches = Context.Batch.Distinct().AsNoTracking().ToList();
            return View();
        }

        public IActionResult AddStudent()
        {
            //view for adding new students
            ViewBag.Batches = Context.Batch.Distinct().AsNoTracking().ToList();
            return View();
        }

        public IActionResult AddBatch()
        {
            //view for adding new batches
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [ValidateAntiForgeryToken]
        public IActionResult AddNewStudent(Student student)
        {
            //Add student to student table
            Context.Student.Add(student);

            //Checks if batchid is empty ie [00000000-0000-0000-0000-000000000000]
            //if it is empty the batchId is set to null to save memory
            if (student.batchId == Guid.Empty)
            {
                student.batchId = null;
            }
            var id = student.batchId;
            Context.SaveChanges();
            return RedirectToAction(nameof(AllStudents));
        }

        [ValidateAntiForgeryToken]
        public IActionResult AddNewBatch(Batch batch)
        {
            //Add batch to batch table
            Context.Batch.Add(batch);
            Context.SaveChanges();
            return RedirectToAction(nameof(AllStudents));
        }
    }
}
