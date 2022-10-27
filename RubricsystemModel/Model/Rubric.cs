using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricsystemModel.Model
{
   public class Rubric
    {
        public int RubricId { get; set; }
        [Required]
        public string RubricName { get; set; }
        [Required]
        public string Subjects { get; set; }
        public string UserId { get; set; }
        [Required]
        public string RubricClass { get; set; }
        public ICollection<EvaluatieTask> EvaluatieTasks { get; set; }
    }
}
