using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricsystemModel.Model
{
   public class Paper
    {
        public int PaperId { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        [Required]
        public string Question1 { get; set; }
        [Required]
        public string Question2 { get; set; }
        [Required]
        public string Question3 { get; set; }
        [Required]
        public string Question4 { get; set; }
        [Required]
        public string Question5 { get; set; }
        public string TeacherId { get; set; }
        public ICollection<Paper> Papers { get; set; }

    }
}
