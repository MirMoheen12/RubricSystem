using Microsoft.AspNetCore.Mvc;
using RubricMangementSystem.Service;
using RubricSystem.Business.Interface;
using RubricsystemModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubricMangementSystem.Controllers
{
    public class StudentController : Controller
    {

        private readonly IUserService _userService;
        private readonly IStudent _studentRepo;
        private readonly AppDbContext _db;

        public StudentController(IUserService userService, IStudent studentRepo, AppDbContext db)
        {
            _userService = userService;
            _studentRepo = studentRepo;
            _db = db;

        }

        public IActionResult Thankyou()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Examiner()
        {
            return View();
        }

        public IActionResult Task()
        {
            return View();
        }
        public IActionResult DisplayResult()
        {
            var Answerdata = _db.Answers.Where(x=>x.StudentId== _userService.GetUserId()).ToList();
            ViewBag.Marks = _db.marksClasses.Where(x => x.StudentID == _userService.GetUserId()).FirstOrDefault();
            var marks = _db.Subcategories.ToList();
  
            return View(Answerdata);
        }
        public IActionResult SuccessPage()
        {
            return View();
        }


        public IActionResult Dummy()
        {
            return View();
        }

        public IActionResult Getlist()
        {
            var userid = _userService.GetUserId();
            var studinfo = _db.Students.Where(x => x.UserId == userid).FirstOrDefault();
            if (studinfo == null)
            {
                return RedirectToAction("Create", "Student");
            }
            var category = _db.Categories.ToList();
            var subcategory = _db.Subcategories.Where(x => x.Class == studinfo.Class && x.Section == studinfo.Section).ToList();
            int val = subcategory.Count();
           
            if (val == 0 )
            {
                return RedirectToAction("Task");
            }
            
            ViewBag.cat = category;
            ViewBag.subcat = subcategory;
            return View();
        }
        [HttpPost]
        public IActionResult Getlist(string[] SubcatAns1)
        {
            var userid = _userService.GetUserId();
            var studinfo = _db.Students.Where(x => x.UserId == userid).FirstOrDefault();

            int num = 0;

            bool flag = true;

            while (flag != false)
            {
                for (int j = 0; j < 1; j++)
                {
                    Answer answer = new Answer();
                    answer.Class = studinfo.Class;
                    answer.Section = studinfo.Section;
                    answer.Answer1 = SubcatAns1[num];
                    answer.StudentId = userid;
                    
                    num++;
                    answer.Answer2 = SubcatAns1[num];
                    num++;
                    answer.Answer3 = SubcatAns1[num];
                    num++;
                    answer.Answer4 = SubcatAns1[num];
                    num++;
                    answer.Answer5 = SubcatAns1[num];
                    num++;

                    _db.Answers.Add(answer);
                    _db.SaveChanges();
                }

                if (num == 60)
                {
                    flag = false;
                }

            }

            return RedirectToAction("SuccessPage","Student");
        }

        public IActionResult GetAllStudents()
        {

            var userid = _userService.GetUserId();

            var students = _studentRepo.GetAllStudents().Where(x => x.UserId == userid);
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            var userid = _userService.GetUserId();
            var stud = _studentRepo.CreateStudent(student, userid);
            if (stud != null)
            {
                return RedirectToAction("Thankyou");
            }
            ViewBag.exist = true;
            return View();
        }

        // get paper
        [HttpGet]
        public IActionResult GetPaper()
        {
            Answer ans = new Answer();
            var userid = _userService.GetUserId();
            var papr = _studentRepo.GetPaper(userid);
            if (papr != null)
            {
                var check = _studentRepo.GetPap(papr.Class, papr.Section);
                if (check != null)
                {
                    //return View(papr);
                    ans.Paper = check;
                    return View(ans);
                }
                else
                {
                    return RedirectToAction("Examiner");
                }

            }
            return RedirectToAction("Create");
        }

        public IActionResult GetPaper(Answer answer)
        {
            var userid = _userService.GetUserId();
            var papr = _studentRepo.SetPaper(userid, answer);
            return RedirectToAction("GetPaper");
        }

        public IActionResult ShowNumber()
        {
            var userid = _userService.GetUserId();
            var num = _studentRepo.ShowNumber(userid);
            if (num != null)
            {
                var total = Int32.Parse(num.Numbers1) + Int32.Parse(num.Number2) + Int32.Parse(num.Number3) + Int32.Parse(num.Number4) + Int32.Parse(num.Number5);
                ViewBag.TotalNumber = total;
                return View();
            }

            return View();

        }


    }
}
