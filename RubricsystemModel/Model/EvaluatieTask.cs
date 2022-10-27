using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricsystemModel.Model
{
   public class EvaluatieTask
    {
        public int EvaluatieTaskId { get; set; }
        [Required]
        public string Question { get; set; }
        public string UserId { get; set; }
        public virtual int RubricId { get; set; }
        [ForeignKey("RubricId")]
        public virtual Rubric Rubric { get; set; }
    }
}
