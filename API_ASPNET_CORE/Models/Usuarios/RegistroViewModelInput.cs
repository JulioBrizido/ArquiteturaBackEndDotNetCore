using System.ComponentModel.DataAnnotations;

namespace API_ASPNET_CORE.Models.Usuarios
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "Login obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Email obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha obrigatória")]
        public string Senha { get; set; }
    }
}
