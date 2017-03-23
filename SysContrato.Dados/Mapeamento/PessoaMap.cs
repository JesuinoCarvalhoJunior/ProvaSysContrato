using FluentNHibernate.Mapping;
using SysContrato.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dados.Mapeamento
{
    public class PessoaMap : ClassMap<Pessoa>
    {
        PessoaMap()
        {
            Id(c => c.Id).GeneratedBy.Native();
            Map(c => c.Nome).Length(60).Not.Nullable();
        }
    }
}
