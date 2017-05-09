using FluentNHibernate.Mapping;
using SysContrato.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dados.Mapeamento
{
    public class PessoaJuridicaMap : SubclassMap<PessoaJuridica>
    {
        PessoaJuridicaMap()
        {
            Map(c => c.Cnpj).Length(14).Not.Nullable();
            Map(c => c.DataAbertura).Not.Nullable();
        }
    }
}
