using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _222.ViewModels
{
    public class SignUpData
    {
        [Display(Name = "姓名")]

        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string NameMessage { get; set; }
        public string AccountMessage { get; set; }
        public string PasswordMessage { get; set; }
        public string Message { get; set; }

    }
}