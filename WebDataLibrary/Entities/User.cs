using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDataLibrary.Entities
{
    public class User
    {
        public User()
        {

        }
        [Key]
        [Display(Name = "User Id:")]
        public int UserId { get; set; }

        [Display(Name = "Name:")]
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Display(Name = "Surname:")]
        [Required]
        [MaxLength(100)]
        public string Surname { get; set; }

        [Display(Name = "Login:")]
        [Required]
        [MaxLength(40)]
        public string Login { get; set; }

        [Display(Name = "Password:")]
        [Required]
        [MaxLength(40)]
        public string Password { get; set; }

        [Display(Name = "Login status:")]
        [MaxLength(20)]
        public string LoginStatus { get; set; }

        [Display(Name = "Active:")]
        public bool Active { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
