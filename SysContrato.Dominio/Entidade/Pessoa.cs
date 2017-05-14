using System.Collections.Generic;
using System.Linq;

namespace SysContrato.Dominio.Entidade
{
    public abstract class Pessoa
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<Telefone> Telefones { get; set; }

        public virtual string CPFCNPJ
        {
            get
            {
                return this is PessoaFisica ? (this as PessoaFisica).Cpf : (this as PessoaJuridica).Cnpj;
            }
        }
        public Pessoa()
        {
           this.Telefones = new List<Telefone>();
       }
        public virtual Telefone TelefonePrincipal
        {
            get { return Telefones.FirstOrDefault(c => c.Principal); }
        }
    }
}