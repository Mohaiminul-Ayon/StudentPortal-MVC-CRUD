using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.data;
using StudentPortal.Web.Models;
using StudentPortal.Web.Models.Entities;

namespace StudentPortal.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDBcontext dbContext;
        public StudentController(ApplicationDBcontext dbContext)
        {
            this.dbContext = dbContext;
        }

        //public ApplicationDBcontext DbContext { get; }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViweModel viewModel) {
            var student = new Student
            {
                Name = viewModel.Name,
                email = viewModel.email,
                phone = viewModel.phone,
                Subscribed = viewModel.Subscribed
            };


            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();


            return View();
        }


        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await dbContext.Students.ToListAsync();
            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);
            return View(student);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Student viweModel)
        {
            var student = await dbContext.Students.FindAsync(viweModel.Id);
            if (student is not null)
            {
                student.Name = viweModel.Name;
                student.email = viweModel.email;
                student.phone = viweModel.phone;
                student.Subscribed = viweModel.Subscribed;

                await dbContext.SaveChangesAsync();
            }


            return RedirectToAction("List","Student");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Student viweModel)
        {
            var student = await dbContext.Students.FindAsync(viweModel.Id);

            if (student is not null)
            {
                dbContext.Students.Remove(student);
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Student");

        }

    }
}
