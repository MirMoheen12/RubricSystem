using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricsystemModel.Model
{
   public class Answer
    {
        public int AnswerId { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        [Required]
        public string Answer1 { get; set; }
        public string Numbers1 { get; set; }
        [Required]
        public string Answer2 { get; set; }
        public string Number2 { get; set; }
        [Required]
        public string Answer3 { get; set; }
        public string Number3 { get; set; }
        [Required]
        public string Answer4 { get; set; }
        public string Number4 { get; set; }
        [Required]
        public string Answer5 { get; set; }
        public string Number5 { get; set; }
        [Required]
        public bool IsSolved { get; set; }
        public bool IsChecked { get; set; }
        public string TeacherId { get; set; }
        public string StudentId { get; set; }

        public virtual int? SubcategoryId { get; set; }
        [ForeignKey("SubcategoryId")]
        public virtual Subcategory Subcategory { get; set; }

        public virtual int? PaperId { get; set; }
        [ForeignKey("PaperId")]
        public virtual Paper Paper { get; set; }
    }
}
