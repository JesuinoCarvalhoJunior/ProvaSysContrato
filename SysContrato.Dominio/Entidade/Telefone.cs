using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dominio.Entidade
{
  public  class Telefone
    {
        public virtual int Id { get; set; }
        public virtual int CodigoDdd { get; set; }
        public virtual int Numero { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
