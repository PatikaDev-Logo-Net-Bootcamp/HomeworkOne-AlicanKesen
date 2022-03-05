using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkOne.Models
{
    public class InfoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad zorunludur!")]
        [Display(Name = "Adınız")]
        //[RegularExpression("(?=.*[A-Z](?=.*[a-z])", ErrorMessage = "Geçerli bir ad giriniz!")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Soyadı zorunludur!")]
        [Display(Name = "Soyadınız")]
        //[RegularExpression("(?=.*[A-Z](?=.*[a-z])", ErrorMessage = "Geçerli bir soyad giriniz!")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Mail alanı zorunludur!")]
        [Display(Name = "E-mail")]
        [RegularExpression("^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]*\\.[A-Za-z0-9-]{2,}$", ErrorMessage = "Geçerli bir e-mail adresi giriniz!")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Required(ErrorMessage = "Şifre Zorunludur!")]
        [RegularExpression("(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,}", ErrorMessage = "Şifre en az 8 karakter olmalı ve bir büyük harf, bir küçük harf ve bir rakam içermelidir.")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}
