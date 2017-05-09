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
    public class RepositorioCliente : RepositorioBase<Cliente>, IRepositoryCliente<Cliente>
    {

        public IList<Cliente> PesquisarPorNome(string nome)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                try
                {
                    return session.Query<Cliente>().Where(c => c.Nome.Contains(nome)).ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao pesquisa o registro" + ex.Message);

                }
            }

        }



        public bool ClienteTemContrato(int IdCliente)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                try
                {
                    return session.Query<Contrato>().Any(c => c.Id == IdCliente);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao pesquisar o registro" + ex.Message);
                }
            }
        }

        public bool CPFExiste(string CPF)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                try
                {
                    return session.Query<Cliente>().Any(c => c.CPF == CPF);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao pesquisar o registro" + ex.Message);
                }
            }
        }

        public IList<Cliente> PesquisarPorCPF(string CPF)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                try
                {
                    return session.Query<Cliente>().Where(c => c.CPF.Contains(CPF)).ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao pesquisa o registro" + ex.Message);

                }
            }
        }
    }
}
