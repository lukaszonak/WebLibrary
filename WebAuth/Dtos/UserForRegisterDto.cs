using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuth.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 4, ErrorMessage = "Hasło musi zawierać od 4 do 10 znaków")]
        public string Password { get; set; }
    }
}
