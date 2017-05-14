using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dados
{
    public static class NHibernateHelper
    {
        private static string StringConexao = "Data Source=JCARVALHOJR\\SQLEXPRESS;Initial Catalog=SysContrato;Integrated Security=True";
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    Configurar();
                return _sessionFactory;
            }
        }

        public static void Configurar()
        {
            FluentConfiguration configuracao = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(StringConexao)
                .ShowSql())
                .Mappings(c => c.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .ExposeConfiguration(c => new SchemaUpdate(c).Execute(true, true));

            _sessionFactory = configuracao.BuildSessionFactory();
        }
        public static ISession AbrirSessao()
        {
            return _sessionFactory.OpenSession();
        }

       
    }
}
