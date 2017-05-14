using FluentNHibernate.Mapping;
using SysContrato.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dados.Mapeamento
{
    public class TelefoneMap : ClassMap<Telefone>
    {

        TelefoneMap()
        {

            Id(c => c.Id).GeneratedBy.Native();

            Map(c => c.CodigoDdd)
                .Not.Nullable()
                .Length(3);

            Map(c => c.Numero)
                .Not.Nullable().Length(9);

            Map(c => c.Principal)
                .Not.Nullable().Length(1);

          //  References(c => c.Pessoa);

             References(c => c.Pessoa).Fetch.Join().Not.LazyLoad(); 
           //References(c => c.Pessoa, "Pessoa_Id").Fetch.Join();
 

        }
    }
}
