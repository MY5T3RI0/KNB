using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KNB.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Укажите Email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Укажите Пароль!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}