using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricsystemModel.Model
{
   public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }     
        public string UserId { get; set; }
    }
}
