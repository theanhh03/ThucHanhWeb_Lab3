using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThucHanh3.Models;

namespace ThucHanh3.Controllers
{
    public class StudentController : Controller
    {

        private List<Student> listStudent = new List<Student>();
        public StudentController()
        {
            listStudent = new List<Student>()
            {
                new Student()
                {
                    Id = 101,
                    Name = "Phạm A",
                    Branch = Branch.IT,
                    Gender = Gender.Male,
                    IsRegular = true,
                    Address = "A1-2018",
                    Email = "phamA@g.com",
                    Diem = 10
                },

                new Student()
                {
                    Id = 102,
                    Name = "Nguyễn B",
                    Branch = Branch.BE,
                    Gender = Gender.Female,
                    IsRegular = true,
                    Address = "A1-2019",
                    Email = "nguyenB@g.com",
                    Diem = 9
                },

                new Student()
                {
                    Id = 103,
                    Name = "Hoàng C",
                    Branch = Branch.CE,
                    Gender = Gender.Male,
                    IsRegular = true,
                    Address = "A1-2020",
                    Email = "hoangC@g.com",
                    Diem = 7
                },

                new Student()
                {
                    Id = 104,
                    Name = "Đặng D",
                    Branch = Branch.EE,
                    Gender = Gender.Female,
                    IsRegular = true,
                    Address = "A1-2021",
                    Email = "dangD@g.com",
                    Diem = 2
                }
            };
        }
        //[Route("Admin/Student/Add")]
        //[HttpGet()]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem {Text = "IT", Value = "1"},
                new SelectListItem {Text = "BE", Value = "2"},
                new SelectListItem {Text = "CE", Value = "3"},
                new SelectListItem {Text = "EE", Value = "4"},
            };
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            if(ModelState.IsValid)
            {
                s.Id = listStudent.Last<Student>().Id + 1;
                listStudent.Add(s);
                return View("Index", listStudent);
            }
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
{
            new SelectListItem { Text = "IT", Value = "1" },
            new SelectListItem { Text = "BE", Value = "2" },
            new SelectListItem { Text = "CE", Value = "3" },
            new SelectListItem { Text = "EE", Value = "4" }
            };
            return View();
        }

        //[Route("Admin/Student/List")]
        public IActionResult Index()
        {
            return View(listStudent);
        }
    }
}