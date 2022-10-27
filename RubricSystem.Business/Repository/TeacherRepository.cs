using RubricSystem.Business.Interface;
using RubricsystemModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace RubricSystem.Business.Repository
{
    public class TeacherRepository : ITeacher
    {
        private readonly AppDbContext _db;

        public TeacherRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Teacher> GetAllTeachers()
        {
            var teacher = _db.Teachers.ToList();
            return teacher;
        }

        [HttpPost]
        public Teacher CreateTeacher(Teacher teacher, string userid)
        {
            teacher.UserId = userid;
            var teacherexist = _db.Teachers.Where(x => x.UserId == teacher.UserId).FirstOrDefault();
            if (teacherexist == null)
            {
                var teach = _db.Teachers.Add(teacher).Entity;
                _db.SaveChanges();
                return teach;
            }
            return null;
        }

        [HttpPost]
        public Rubric CreateRubric(Rubric rubric, string userid)
        {
            rubric.UserId = userid;
            var rub = _db.Rubrics.Add(rubric).Entity;
            _db.SaveChanges();
            return rub;
        }

     



        [HttpPost]
        public EvaluatieTask CreateEvaluatie(EvaluatieTask evaluatieTask, string userid)
        {
            evaluatieTask.UserId = userid;
            var rub = _db.EvaluatieTasks.Add(evaluatieTask).Entity;
            _db.SaveChanges();
            return rub;
        }

        public List<Rubric> GetAllRubrics()
        {
            var Rubric = _db.Rubrics.ToList();
            return Rubric;
        }

        public Teacher getdetail(string id)
        {
            var detail = _db.Teachers.Where(x => x.UserId == id).FirstOrDefault();
            return detail;
        }

        [HttpPost]
        public Paper CreatePaper(Paper paper)
        {
            var exis = _db.Papers.Where(x => x.TeacherId == paper.TeacherId).FirstOrDefault();
            if (exis == null)
            {
                var rub = _db.Papers.Add(paper).Entity;
                _db.SaveChanges();
                return rub;
            }
            return null;
        }

        //public Student GetPaper(string userid)
        //{
        //    var stu = _db.Students.Where(x => x.UserId == userid).FirstOrDefault();
        //    return stu;
        //}

        public Paper PaperObj(string Class, string Section)
        {
            var stu = _db.Papers.Where(x => x.Class == Class && x.Section == Section).FirstOrDefault();
            
            return stu;
        }

        public List<Answer> SolvedPaper()
        {
            var ans = _db.Answers.ToList();
            return ans;
        }

        public Answer GetStudentPaper(string id)
        {
            var getstudentpaper = _db.Answers.Where(x => x.StudentId == id).FirstOrDefault();
            return getstudentpaper;
        }

        public Answer SaveNumbers(Answer answer)
        {
            var rub = _db.Answers.Update(answer).Entity;
            _db.SaveChanges();
            return rub;
        }

    }
}
