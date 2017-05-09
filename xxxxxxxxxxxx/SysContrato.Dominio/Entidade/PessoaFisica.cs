using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dominio.Entidade
{
  public  class PessoaFisica : Pessoa
    {
        public virtual string Cpf { get; set; }
        public virtual DateTime DataNascimento { get; set; }
    }
}
