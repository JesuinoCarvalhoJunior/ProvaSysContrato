using SysContrato.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dominio.Repositorio
{
    public interface IRepositoryCliente<Cliente>
    {
        IList<Cliente> PesquisarPorNome(string nome);

        IList<Cliente> PesquisarPorCPF(string CPF);

        bool ClienteTemContrato(int IdCliente);

        bool CPFExiste(string CPF);


    }
}
