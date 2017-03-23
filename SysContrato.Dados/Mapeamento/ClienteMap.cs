using FluentNHibernate.Mapping;
using SysContrato.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dados.Mapeamento
{
    public class ClienteMap : ClassMap<Cliente>
    {

        ClienteMap(){
            Id(c => c.Id).GeneratedBy.Native();

            Map(c => c.Nome).Length(60).Not.Nullable();
            Map(c => c.CPF).Length(11).Not.Nullable();
            Map(c => c.CNPJ).Length(14).Not.Nullable();
        }
     }
}
