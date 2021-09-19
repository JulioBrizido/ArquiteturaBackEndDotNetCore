using API_ASPNET_CORE.Business.Entities;
using System.Collections.Generic;

namespace API_ASPNET_CORE.Business.Repositories
{
    public interface ICursoRepository
    {
        void Adicionar(Curso curso);
        void commit();
        IList<Curso> ObterPorUsuario(int codigoUsuario);
    }
}
