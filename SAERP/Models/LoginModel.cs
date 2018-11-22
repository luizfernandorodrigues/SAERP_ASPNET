using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAERP.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Usuário:")]
        private string usuario;
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        private string senha;
        [Display(Name = "Lembrar Me")]
        private bool lembrarMe;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public bool LembrarMe { get => lembrarMe; set => lembrarMe = value; }
    }
}