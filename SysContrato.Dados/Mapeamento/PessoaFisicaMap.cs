using FluentNHibernate.Mapping;
using SysContrato.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dados.Mapeamento
{
    public class PessoaFisicaMap : SubclassMap<PessoaFisica>
    {
        PessoaFisicaMap()
        {
            Map(c => c.Cpf).Length(14).Not.Nullable();
            Map(c => c.DataNascimento).Not.Nullable();
        }
    }
}
