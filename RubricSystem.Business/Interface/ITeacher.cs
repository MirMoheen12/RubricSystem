using RubricsystemModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricSystem.Business.Interface
{
   public interface ITeacher
    {
        public List<Teacher> GetAllTeachers();
        public Teacher CreateTeacher(Teacher teacher, string userid);     
        public Rubric CreateRubric(Rubric rubric, string userid);
        public EvaluatieTask CreateEvaluatie(EvaluatieTask evaluatieTask, string userid);
        public List<Rubric> GetAllRubrics();
        public Teacher getdetail(string id);
        public Paper CreatePaper(Paper paper);

        //public Student GetPaper(string userid);
        //public Paper GetPap(string Class, string Section);

        public Answer GetStudentPaper(string id);

        public List<Answer> SolvedPaper();
        public Paper PaperObj(string Class, string Section);
        public Answer SaveNumbers(Answer answer);


    }
}
