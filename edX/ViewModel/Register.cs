﻿using System.ComponentModel.DataAnnotations;

namespace edX.ViewModel
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage = "Şifre Uyuşmadı")]
        public string confirmPassword { get; set; }

    }
}
