using RubricsystemModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricSystem.Business.Interface
{
   public interface IStudent
    {
        public List<Student> GetAllStudents();
        public Student CreateStudent(Student student , string userid);

        public Student GetPaper(string userid);
        public Paper GetPap(string Class,string Section);
        public Answer SetPaper(string userid, Answer answer);
        public Answer ShowNumber(string userid);
    }
}
