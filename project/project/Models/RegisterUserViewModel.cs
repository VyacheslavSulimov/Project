using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace project.Models
{
    public class RegisterUserViewModel
    {
        [Required]
        [Display(Name = "Имя")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Отчество")]
        public string Forename { get; set; }


        [Required]
        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}