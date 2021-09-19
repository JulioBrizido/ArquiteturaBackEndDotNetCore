using System.ComponentModel.DataAnnotations;

namespace API_ASPNET_CORE.Models.Usuarios
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "Login obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Senha obrigatória")]
        public string Senha { get; set; }
    }
}
