using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysContrato.Dominio.Repositorio
{
    public   interface IRepositoryBase<T> where T : class
    {
        void Inserir(T entidade);
        void Alterar(T entidade);
        void Excluir(T entidade);

        T PesquisarPorId(int id);

            T Pesquisar();


    }
}
