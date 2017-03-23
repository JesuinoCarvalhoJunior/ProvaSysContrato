using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dominio.Entidade
{
   public class Contrato
    {
        public virtual int Id { get; set; }
        public virtual string Numero { get; set; }

        public virtual DateTime DataInicio { get; set; }

        public virtual DateTime DataFim { get; set; }
       
        public virtual string Descricao { get; set; }

        public virtual Double Valor { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}
