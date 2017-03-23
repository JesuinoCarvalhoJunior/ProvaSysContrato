using SysContrato.Dados.Repositorio;
using SysContrato.Dominio.Entidade;
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
    
    public partial class FClienteEdicao : Form
    {
        private int clienteId;
        private RepositorioCliente _repositorioCliente;
        private Cliente _cliente;
        public FClienteEdicao()
        {
            InitializeComponent();

            clienteBindingSource.DataSource = _cliente;

            _repositorioCliente = new RepositorioCliente();
        }


        public int ClienteId
        {
            get { return clienteId; }
            set
            {
                clienteId = value;
                ListarCliente();
            }

        }

        private void ListarCliente()
        {
            _cliente = _repositorioCliente.PesquisarPorId(ClienteId);
            clienteBindingSource.DataSource = _cliente;
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sysContratoDataSet1);

        }

        private void FClienteEdicao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysContratoDataSet1.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.sysContratoDataSet1.Cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _repositorioCliente.Alterar(_cliente);
            this.Close();

        }
    }
}
