using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Digite o E-mail !")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Digite a Senha !")]
        public string Senha { get; set; }
    }
}
