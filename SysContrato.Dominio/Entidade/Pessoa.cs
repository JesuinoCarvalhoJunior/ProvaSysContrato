using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dominio.Entidade
{
  public abstract class Pessoa 
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
    }
}
