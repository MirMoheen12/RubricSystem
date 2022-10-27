using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricsystemModel.Model
{
   public class Subcategory
    {
        public int SubcategoryId { get; set; }

        public virtual int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public string SubcategoryName { get; set; }

        public string Class { get; set; }
        public string Section { get; set; }

        public string UserId { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}
