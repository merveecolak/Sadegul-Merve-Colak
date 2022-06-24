using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BussApp.WebUI.Models
{
    public class LoginModel
    {
         [Required(ErrorMessage = "Kullanıcı Adı Boş Bırakılamaz!")]
         public string UserName { get; set; }

         [Required(ErrorMessage = "Şifrenizi Giriniz!")]
         [DataType(DataType.Password)]
         public string Password { get; set; }
         public string ReturnUrl { get; set; }
    }
}
