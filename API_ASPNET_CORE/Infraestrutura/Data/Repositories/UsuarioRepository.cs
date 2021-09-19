using API_ASPNET_CORE.Business.Entities;
using API_ASPNET_CORE.Business.Repositories;
using System.Linq;

namespace API_ASPNET_CORE.Infraestrutura.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CursoDbContext _contexto;
        public UsuarioRepository(CursoDbContext contexto)
        {
            this._contexto = contexto;
        }

        public void Adicionar(Usuario usuario)
        {
            _contexto.Usuario.Add(usuario);
        }

        public void commit()
        {
            _contexto.SaveChanges();
        }

        public Usuario ObterUsuario(string login)
        {
            return _contexto.Usuario.FirstOrDefault(u => u.Login == login);
        }
    }
}
