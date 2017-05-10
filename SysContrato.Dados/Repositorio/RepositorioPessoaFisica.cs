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

    public class RepositorioPessoaFisica : RepositorioBase<Pessoa>, IRepositoryPessoaFisica<PessoaFisica>
    {
        public bool CPFExiste(string CPF)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                try
                {
                    return session.Query<PessoaFisica>().Any(c => c.Cpf == CPF);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao pesquisar o registro" + ex.Message);
                }
            }
        }

        public IList<PessoaFisica> PesquisarPorCPF(string CPF)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                try
                {
                    return session.Query<PessoaFisica>().Where(c => c.Cpf.Equals(CPF)).ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao pesquisa o registro" + ex.Message);

                }
            }
        }

        public IList<PessoaFisica> PesquisarPorCPFAproximado(string CPF)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                try
                {
                    return session.Query<PessoaFisica>().Where(c => c.Cpf.Contains(CPF)).ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao pesquisa o registro" + ex.Message);

                }
            }
        }
    }
}

