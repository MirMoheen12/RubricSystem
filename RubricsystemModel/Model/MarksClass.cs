using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricsystemModel.Model
{
   public class MarksClass
    {
        [Key]
        public int MarksID { get; set; }
        public string StudentID { get; set; }
        public string Num1 { get; set; }
        public string Num2 { get; set; }
        public string Num3 { get; set; }
        public string Num4 { get; set; }
        public string Num5 { get; set; }
    }
}
