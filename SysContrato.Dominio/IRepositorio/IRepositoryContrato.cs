using SysContrato.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dominio.Repositorio
{
   public interface IRepositoryContrato<Contrato>
    {
        
        IList<Contrato> PesquisarContratoPorNumero(string NumeroContrato);
    }
}
