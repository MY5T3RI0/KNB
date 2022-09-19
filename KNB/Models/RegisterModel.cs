using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KNB.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Укажите Email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Укажите Возраст!")]
        public int UserAge { get; set; }

        [Required(ErrorMessage = "Укажите Пароль!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Подтвердите пароль!")]
        [Compare("Password", ErrorMessage ="Пароли не совпадают!")]
        public string ConfirmPassword { get; set; }
    }
}