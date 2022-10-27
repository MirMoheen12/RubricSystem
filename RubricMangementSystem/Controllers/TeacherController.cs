using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RubricMangementSystem.Service;
using RubricSystem.Business.Interface;
using RubricsystemModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubricMangementSystem.Controllers
{
    public class TeacherController : Controller
    {

        private readonly IUserService _userService;
        private readonly ITeacher _teacherRepo;
        private readonly AppDbContext _db;

        public TeacherController(IUserService userService, ITeacher teacherRepo, AppDbContext db)
        {
            _userService = userService;
            _teacherRepo = teacherRepo;
            _db = db;
        }

        public IActionResult Notify()
        {
            return View();
        }
        public IActionResult CheckRubric()
        {
            List<PaperDto> paperDtos = new List<PaperDto>();
            var data = _db.Answers.ToList().Join(_db.Students.ToList(), P => P.StudentId, M => M.UserId, (P, M) => new
            {
                P.StudentId,
                M.Name,

            }).Distinct().ToList();

            foreach (var item in data)
            {
                PaperDto paperDto = new PaperDto();
                paperDto.StudentId = item.StudentId;
                paperDto.Name = item.Name;
                paperDtos.Add(paperDto);

            }
         
            return View(paperDtos);
        }

        public IActionResult AssignMarks(string id)
        {
            var anslist = _db.Answers.Where(x => x.StudentId == id).ToList();
            ViewBag.id = id;
            return View(anslist);
        }
        [HttpPost]
        public IActionResult submismarks(string Num1, string Num2, string Num3, string Num4, string Num5,string stdid)
        {
            MarksClass marksClass = new MarksClass();
            marksClass.Num1 = Num1;
            marksClass.Num2 = Num2;
            marksClass.Num3 = Num3;
            marksClass.Num4 = Num4;
            marksClass.Num5 = Num5;
            marksClass.StudentID = stdid;
            _db.marksClasses.Add(marksClass);
            _db.SaveChanges();
            return View("Thankyou");
        }


        public IActionResult Thankyou()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rubric()
        {
            var category = _db.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Rubric(FormDto formDto)
        {
            var userid = _userService.GetUserId();
            save(formDto.Subcat1,formDto.Class,formDto.Section, userid);
            save(formDto.Subcat2, formDto.Class, formDto.Section, userid);
            save(formDto.Subcat3, formDto.Class, formDto.Section, userid);
            save(formDto.Subcat4, formDto.Class, formDto.Section, userid);
            save(formDto.Subcat5, formDto.Class, formDto.Section, userid);
            save(formDto.Subcat6, formDto.Class, formDto.Section, userid);
            save(formDto.Subcat7, formDto.Class, formDto.Section, userid);
            save(formDto.Subcat8, formDto.Class, formDto.Section, userid);
            save(formDto.Subcat9, formDto.Class, formDto.Section, userid);
            save(formDto.Subcat10, formDto.Class, formDto.Section, userid);
            save(formDto.Subcat11, formDto.Class, formDto.Section, userid);
            save(formDto.Subcat12, formDto.Class, formDto.Section, userid);

            return View();
        }

        public void save( string inputfield,string Class,string Section , string userid)
        {
            //var userid = _userService.GetUserId();

            Subcategory subcategory = new Subcategory();
            subcategory.SubcategoryName = inputfield;
            subcategory.Class = Class;
            subcategory.Section = Section;
            subcategory.UserId = userid;
            _db.Subcategories.Add(subcategory);
            _db.SaveChanges();
        }

        public IActionResult GetAllTeachers()
        {
            var userid = _userService.GetUserId();
            var teacher = _teacherRepo.GetAllTeachers().Where(x => x.UserId == userid);
            return View(teacher);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            var userid = _userService.GetUserId();
            var teach = _teacherRepo.CreateTeacher(teacher, userid);
            if (teach != null)
            {
                return RedirectToAction("Thankyou");
            }
            ViewBag.exist = true;
            return View();
        }

        public IActionResult CreateRubric()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateRubric(Rubric rubric)
        {
            var userid = _userService.GetUserId();
            var teach = _teacherRepo.CreateRubric(rubric, userid);
            return RedirectToAction("CreateEvaluatie", "Teacher");
        }

        public IActionResult CreateEvaluatie()
        {

            ViewBag.Rubric = new SelectList(_teacherRepo.GetAllRubrics(), "RubricId", "Subjects");
            return View();
        }
        [HttpPost]
        public IActionResult CreateEvaluatie(EvaluatieTask evaluatieTask)
        {
            var userid = _userService.GetUserId();
            var evaluatie = _teacherRepo.CreateEvaluatie(evaluatieTask, userid);
            return View();
        }

        // create paper 
        [HttpGet]
        public IActionResult CreatePaper(string id)
        {
            var userid = _userService.GetUserId();
           
            var paper = new Paper();

            var detail = _teacherRepo.getdetail(id);
            paper.TeacherId = detail.UserId;
            paper.Class = detail.Class;
            paper.Section = detail.Section;

            return View(paper);
        }
        [HttpPost]
        public IActionResult CreatePaper(Paper paper)
        {
            var userid = _userService.GetUserId();
            var detail = _teacherRepo.CreatePaper(paper);
            if (detail != null)
            {
                ViewBag.ok = "true";
            }
            else
            {
                ViewBag.ok = "false";
            }
            return View();
        }

        public IActionResult SolvedPaper()
        {
            var userid = _userService.GetUserId();
            var list = _db.Papers.Where(x => x.TeacherId == userid).FirstOrDefault();
            var teacher = _teacherRepo.SolvedPaper().Where(x => x.Class == list.Class && x.Section == list.Section).ToList();
            return View(teacher);
        }

        [HttpGet]
        public IActionResult GetPaper(string id)
        {
            var userid = _userService.GetUserId();
            var getstudentpaper = _teacherRepo.GetStudentPaper(id);
            var Class = getstudentpaper.Class;
            var Section = getstudentpaper.Section;
            Answer ans = new Answer();
            var paperobj = _teacherRepo.PaperObj(Class,Section);
            //var papr = _teacherRepo.GetPaper(userid);
            //var check = _teacherRepo.GetPap(papr.Class, papr.Section);
            ////return View(papr);
            ans = getstudentpaper;
            ans.Paper = paperobj;
            return View(ans);
        }

        public IActionResult GetPaper(Answer answer)
        {
            var savenumbers = _teacherRepo.SaveNumbers(answer);
            return RedirectToAction("SolvedPaper");
        }
    }
}
