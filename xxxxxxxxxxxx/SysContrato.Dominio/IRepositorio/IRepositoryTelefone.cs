using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dominio.IRepositorio
{
   public interface IRepositoryTelefone<Telefone>
    {
        IList<Telefone> PesquisarPorTelefone(string NumeroTelfone);
    }
}
