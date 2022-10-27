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
   public class StudentRepository : IStudent
    {
        private readonly AppDbContext _db;

        public StudentRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Student> GetAllStudents()
        {
            var students = _db.Students.ToList();
            return students;
        }

        [HttpPost]
        public Student CreateStudent(Student student , string userid)
        {
            var exisstudent = _db.Students.Where(x => x.UserId == userid).FirstOrDefault();
            if (exisstudent == null)
            {
                student.UserId = userid;
                var stud = _db.Students.Add(student).Entity;
                _db.SaveChanges();
                return stud;
            }
            return null;
        }

        public Student GetPaper(string userid)
        {
            var stu = _db.Students.Where(x => x.UserId == userid).FirstOrDefault();
            return stu;
        }

        public Paper GetPap(string Class, string Section)
        {
            var stu = _db.Papers.Where(x => x.Class == Class && x.Section == Section).FirstOrDefault();
            return stu;
        }

        public Answer SetPaper(string userid ,Answer answer )
        {
            
            answer.StudentId = userid;
          
            var stud = _db.Answers.Add(answer).Entity;
            _db.SaveChanges();
            return stud;
        }

        public Answer ShowNumber(string userid)
        {
            var num = _db.Answers.Where(x => x.StudentId == userid).FirstOrDefault();
            return num;
        }
    }
}
