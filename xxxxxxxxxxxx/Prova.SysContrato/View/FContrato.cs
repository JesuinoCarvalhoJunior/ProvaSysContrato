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
    public partial class FContrato : Form
    {

        Contrato contrato = new Contrato();
        Cliente cliente = new Cliente();

        private RepositorioContrato _repositorioContrato;
        private RepositorioCliente _repositorioCliente;
        public FContrato()
        {
            InitializeComponent();

            ListarContrato();
            ListarCliente();

            contratoBindingSource.DataSource = contrato;
        }

        private void ListarContrato()
        {
            if (_repositorioContrato == null)
            {
                _repositorioContrato = new RepositorioContrato();
            }
            contratoDataGridView.DataSource = _repositorioContrato.Pesquisa();
        }

        private void ListarCliente()
        {
            if (_repositorioCliente == null)
            {
                _repositorioCliente = new RepositorioCliente();
            }

            nomeComboBox.DataSource = _repositorioCliente.Pesquisa();
        }

        private void contratoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contratoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sysContratoDataSet);

        }

        private void FContrato_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysContratoDataSet1.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.sysContratoDataSet1.Cliente);
            // TODO: This line of code loads data into the 'sysContratoDataSet.Contrato' table. You can move, or remove it, as needed.
            this.contratoTableAdapter.Fill(this.sysContratoDataSet.Contrato);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _repositorioCliente = new RepositorioCliente();
            _repositorioContrato = new RepositorioContrato();

            var cli = _repositorioCliente.PesquisarPorId(Convert.ToInt32(nomeComboBox.SelectedValue));

            contrato.DataInicio = DateTime.Parse(dataInicioDateTimePicker.Value.ToString("dd-MM-yyyy"));
            contrato.DataFim = DateTime.Parse(dataFimDateTimePicker.Value.ToString("dd-MM-yyyy"));
            _repositorioContrato.Inserir(contrato);
            ListarContrato();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (contratoDataGridView.RowCount > 0)
            {
                try
                {
                    _repositorioContrato = new RepositorioContrato();
                    contrato = _repositorioContrato.PesquisarPorId(Convert.ToInt32(contratoDataGridView.CurrentRow.Cells[0].Value));
                    _repositorioContrato.Excluir(contrato);
                    ListarContrato();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao excluir o registro " + ex.Message);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           // _repositorioContrato = new RepositorioContrato();
           // _repositorioContrato.Alterar(contratoDataGridView.SelectedRows.ToString());
        }
    }
}
