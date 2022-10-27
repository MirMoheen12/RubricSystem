using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricsystemModel.Model
{
   public class Teacher
    {
        public int TeacherId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Department { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }      
        public string UserId { get; set; }
    }
}
