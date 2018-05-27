using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WebDataLibrary.Entities
{
    public class Hire
    {
        public Hire()
        {
        }

        [Key]
        [Display(Name = "Hire Id:")]
        public int HireId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date:")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Person")]
        [MaxLength(100)]
        [Required]
        public string Person { get; set; }
        
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

         
    }

    
}
