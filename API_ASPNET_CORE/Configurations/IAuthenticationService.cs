using API_ASPNET_CORE.Models.Usuarios;

namespace API_ASPNET_CORE.Configurations
{
    public interface IAuthenticationService
    {
        string GerarToken(UsuarioViewModelOutput usuarioViewModelOutput);
    }
}
