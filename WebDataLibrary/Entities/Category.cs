using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDataLibrary.Entities
{
    public class Category
    {
        public Category()
        {
        }

        [Key]
        [Display(Name = "CategoryId:")]
        public int Id { get; set; }
        
        [Display(Name = "Category name:")]
        public string CategoryName { get; set; }

        public virtual ICollection<Position> Positions { get; set; }

    }
}
