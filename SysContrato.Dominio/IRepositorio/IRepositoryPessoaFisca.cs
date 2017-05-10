using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dominio.IRepositorio
{
    public interface IRepositoryPessoaFisica<PessoaFisica>
    {
        IList<PessoaFisica> PesquisarPorCPF(string CPF);

        IList<PessoaFisica> PesquisarPorCPFAproximado(string CPF);

        bool CPFExiste(string CPF);


    }
}
