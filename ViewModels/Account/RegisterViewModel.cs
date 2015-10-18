using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tiqe_web.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O {0} não pode ficar vazio")]
        [StringLength(20)]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "O {0} não pode ficar vazio")]
        [StringLength(20)]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }
        
        [DisplayAttribute(Name = "Data de nascimento")]
        public DateTime Birthday { get; set; }
        
        [Required]
        [StringLength(100)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter no mínimo {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a senha")]
        [Compare("Password", ErrorMessage = "A senha e a confirmação da senha não são iguais. Tente novamente.")]
        public string ConfirmPassword { get; set; }
        
        [Required(ErrorMessage = "É necessário aceitar os termos de uso para se registrar na aplicação.")]
        [DisplayAttribute(Name="Aceitar os termos de uso")]
        public bool UseTerms { get; set; }
    }
}
