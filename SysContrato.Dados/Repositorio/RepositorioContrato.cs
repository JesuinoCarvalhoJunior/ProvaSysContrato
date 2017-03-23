using SysContrato.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysContrato.Dominio.Repositorio;
using NHibernate;
using NHibernate.Linq;

namespace SysContrato.Dados.Repositorio
{
    public class RepositorioContrato : RepositorioBase<Contrato>, IRepositoryContrato<Contrato>
    {
        public IList<Contrato> PesquisarContratoPorNumero(string NumeroContrato)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                return session.Query<Contrato>().Where(c => c.Numero == NumeroContrato).ToList();
            }
        }
    }
}
