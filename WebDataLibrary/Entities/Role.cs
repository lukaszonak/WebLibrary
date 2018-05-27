using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDataLibrary.Entities
{
    public class Role
    {

        public Role()
        {
        }
        [Key]
        [Display(Name = "RoleId:")]
        public int RoleId { get; set; }
        [Required]
        [Display(Name = "Role name:")]
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
