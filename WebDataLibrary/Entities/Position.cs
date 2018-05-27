using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDataLibrary.Entities
{
    public class Position
    {
        public Position()
        {

        }

        [Key]
        [Display(Name = "Media Id:")]
        public int MediaId { get; set; }

        [Required]
        [Display(Name = "Author")]
        [MaxLength(100)]
        public string Author { get; set; }
        [Required]
        [Display(Name = "Title")]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Media Year")]
        public int MediaYear { get; set; }
        [Required]
        [Display(Name = "Availability")]
        public bool Availability { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Hire> Hires {get;set;}
        public virtual ICollection<Cover> Covers { get; set; }



    }
}
