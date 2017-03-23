using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova.SysContrato.View
{
    public class HelperMensagem
    {
        public static DialogResult resultado;
        public static void confirmaExclusao(string msg, string titulo, MessageBoxButtons botao)
        {
            resultado = MessageBox.Show(msg, titulo, botao);

            if (resultado == DialogResult.No)
            {
                return;
            }
        }
    }
}
