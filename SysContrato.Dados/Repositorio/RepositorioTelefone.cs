using SysContrato.Dominio.Entidade;
using SysContrato.Dominio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dados.Repositorio
{
    public class RepositorioTelefone : RepositorioBase<Telefone>, IRepositoryTelefone<Telefone>
    {
        public IList<Telefone> PesquisarPorTelefone(string NumeroTelfone)
        {
            throw new NotImplementedException();
        }
    }
}
