using NHibernate;
using NHibernate.Linq;
using SysContrato.Dominio.Entidade;
using SysContrato.Dominio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SysContrato.Dados.Repositorio
{
    public class RepositorioPessoa : RepositorioBase<Pessoa>, IRepositoryPessoa<Pessoa>
    {
        public bool ClienteTemContrato(int IdPessoa)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                try
                {
                    return session.Query<Contrato>().Any(c => c.Id == IdPessoa);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao pesquisar o registro" + ex.Message);
                }
            }
        }

        
        public IList<Pessoa> PesquisarPorNome(string nome)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                try
                {
                    return session.Query<Pessoa>().Where(c => c.Nome.Contains(nome)).ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao pesquisa o registro" + ex.Message);

                }
            }
        }
        
    }
}
