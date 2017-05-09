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
    public class RepositorioPessoaJuridica : RepositorioBase<Pessoa>, IRepositoryPessoaJuridica<PessoaJuridica>
    {
        public bool CNPJExiste(string CNPJ)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                try
                {
                    return session.Query<PessoaJuridica>().Any(c => c.Cnpj == CNPJ);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao pesquisar o registro" + ex.Message);
                }
            }
        }

        public IList<PessoaJuridica> PesquisarPorCNPJ(string CNPJ)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                try
                {
                    return session.Query<PessoaJuridica>().Where(c => c.Cnpj.Contains(CNPJ)).ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao pesquisa o registro" + ex.Message);

                }
            }
        }
    }
}
