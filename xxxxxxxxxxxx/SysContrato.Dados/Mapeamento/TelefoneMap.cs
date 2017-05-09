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

            References(c => c.Pessoa);

        }
    }
}
