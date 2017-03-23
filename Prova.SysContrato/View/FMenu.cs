using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova.SysContrato.View
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FCliente cliente = new FCliente())
            {
                try
                {
                    cliente.ShowDialog();
                }catch (Exception ex)
                {
                    throw new Exception("Não foi possível acessar a rotina " + ex.Message);
                }


            }
        }

 
        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FContrato contrato = new FContrato())
            {
                try
                {
                    contrato.ShowDialog();
                }catch (Exception ex)
                {
                    throw new Exception("Não foi possível acessar a rotina " + ex.Message);
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
