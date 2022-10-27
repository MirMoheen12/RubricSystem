using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricsystemModel.Model
{
   public class FormDto
    {
        public int Id { get; set; }
        [Required]
        public string Subcat1 { get; set; }
        [Required]
        public string Subcat2 { get; set; }
        [Required]
        public string Subcat3 { get; set; }
        [Required]
        public string Subcat4 { get; set; }
        [Required]
        public string Subcat5 { get; set; }
        [Required]
        public string Subcat6 { get; set; }
        [Required]
        public string Subcat7 { get; set; }
        [Required]
        public string Subcat8 { get; set; }
        [Required]
        public string Subcat9 { get; set; }
        [Required]
        public string Subcat10 { get; set; }
        [Required]
        public string Subcat11 { get; set; }
        [Required]
        public string Subcat12 { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }


    }
}
