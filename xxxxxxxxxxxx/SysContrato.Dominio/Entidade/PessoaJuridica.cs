using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dominio.Entidade
{
  public  class PessoaJuridica : Pessoa
    {
        public virtual string Cnpj { get; set; }
        public virtual DateTime DataAbertura { get; set; }
    }
}
