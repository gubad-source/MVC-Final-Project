using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models.Login
{
    public class RegisterViewModel
    {
        [DisplayName("Ad Soyad")]
        [Required]
        [MaxLength(50)]
        public string Fullname { get; set; }

        [DisplayName("E-poçt")]
        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Şifrə")]
        [Required]
        [MaxLength(100)]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password { get; set; }

        [DisplayName("Şifrə təsdiqi")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }
}
