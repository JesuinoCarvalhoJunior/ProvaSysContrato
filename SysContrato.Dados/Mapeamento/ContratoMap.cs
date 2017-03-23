using FluentNHibernate.Mapping;
using SysContrato.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dados.Mapeamento
{
   public class ContratoMap : ClassMap<Contrato>
    {

        ContratoMap()
        {
            Id(c => c.Id).GeneratedBy.Native();

            Map(c => c.Numero);
            Map(c => c.Descricao).Length(60);
            Map(c => c.DataInicio);
            Map(c => c.DataFim);
            Map(c => c.Valor);

            References(c => c.Cliente);



        }


    }
}
