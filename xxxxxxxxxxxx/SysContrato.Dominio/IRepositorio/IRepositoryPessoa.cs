using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dominio.IRepositorio
{
    public interface IRepositoryPessoa<Pessoa>
    {
        IList<Pessoa> PesquisarPorNome(string nome);

        bool ClienteTemContrato(int IdPessoa);


    }
}
