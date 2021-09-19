using API_ASPNET_CORE.Business.Entities;

namespace API_ASPNET_CORE.Business.Repositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
        void commit();
        Usuario ObterUsuario(string login);
    }
}
