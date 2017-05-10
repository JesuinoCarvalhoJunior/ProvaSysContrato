using NHibernate;
using NHibernate.Linq;
using SysContrato.Dominio.Entidade;
using SysContrato.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dados.Repositorio
{
    public class RepositorioBase<T> : IRepositoryBase<T> where T : class
    {

        public void Inserir(T entidade)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao inserir registro" + ex.Message);

                    }
                }

            }
        }
        public void Alterar(T entidade)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao alterar o registro" + ex.Message);
                    }
                }
            }
        }

        public void Excluir(T entidade)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidade);
                        transacao.Commit();

                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao deletar o registro" + ex.Message);
                    }
                }
            }
        }


        public IList<T> Pesquisa()
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        return session.Query<T>().ToList();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao realizar a pesquisa" + ex.Message);
                    }
                }

            }
        }

        public T PesquisarPorId(int id)
        {
            using (ISession session = NHibernateHelper.AbrirSessao())
            {
                return session.Get<T>(id);
            }
        }

   
        public T Pesquisar()
        {
            throw new NotImplementedException();
        }
    }
}
