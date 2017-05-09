using NHibernate;
using NHibernate.Linq;
using SysContrato.Dominio.Entidade;
using SysContrato.Dominio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dados.Repositorio
{
    public class RepositorioTelefone : RepositorioBase<Telefone>, IRepositoryTelefone<Telefone>
    {
        public IList<Telefone> PesquisarPorTelefone(string NumeroTelfone)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                try
                {
                    return session.Query<Telefone>().Where(c => c.Numero == NumeroTelfone).ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao pesquisar o registro" + ex.Message);
                }
            }
        }
    }
}
