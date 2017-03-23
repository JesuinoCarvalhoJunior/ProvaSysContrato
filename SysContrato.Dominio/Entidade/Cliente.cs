using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dominio.Entidade
{
   public class Cliente
    {

        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string CPF { get; set; }
        public virtual string CNPJ { get; set; }
        public virtual DateTime DataNascimento { get; set; }

    }
}
