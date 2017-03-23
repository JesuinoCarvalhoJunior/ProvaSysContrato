using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dominio.IRepositorio
{
    public interface IRepositoryPessoaJuridica<PessoaJuridica>
    {
        IList<PessoaJuridica> PesquisarPorCNPJ(string CNPJ);

        bool CNPJExiste(string CNPJ);


      

    }
}
