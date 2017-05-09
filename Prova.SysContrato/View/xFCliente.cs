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
    public partial class FCliente : Form
    {

        private RepositorioCliente _repositorioCliente;
        public Cliente cliente = new Cliente();
        public int IdCliente;

        //
        
        private RepositorioBase<PessoaFisica> _pf;
        private RepositorioBase<PessoaJuridica> _pJ;


        private PessoaFisica pessoaFisca = new PessoaFisica();
        private PessoaJuridica pessoaJuridica = new PessoaJuridica();

        

        private PessoaFisica pf = new PessoaFisica();
        private PessoaJuridica pj = new PessoaJuridica();
        //

        public FCliente()
        {
            InitializeComponent();
            clienteBindingSource.DataSource = cliente;

            pessoaBindingSource.DataSource = pessoaFisca;

            pessoaJuridicaBindingSource.DataSource = pessoaJuridica;

            pessoaJuridicaBindingSource1.DataSource = pessoaJuridica;

            pessoaBindingSource.DataSource = pessoaJuridica;

            ListarCliente();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            clientedataGridView.DataSource = _repositorioCliente.PesquisarPorCPF(textBox1.Text);
        }

        private void FCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysContratoDataSet3.PessoaJuridica' table. You can move, or remove it, as needed.
            this.pessoaJuridicaTableAdapter1.Fill(this.sysContratoDataSet3.PessoaJuridica);
            // TODO: This line of code loads data into the 'sysContratoDataSet3.Pessoa' table. You can move, or remove it, as needed.
            this.pessoaTableAdapter1.Fill(this.sysContratoDataSet3.Pessoa);
            // TODO: This line of code loads data into the 'sysContratoDataSet2.PessoaJuridica' table. You can move, or remove it, as needed.
            this.pessoaJuridicaTableAdapter.Fill(this.sysContratoDataSet2.PessoaJuridica);
            // TODO: This line of code loads data into the 'sysContratoDataSet2.PessoaFisica' table. You can move, or remove it, as needed.
            this.pessoaFisicaTableAdapter.Fill(this.sysContratoDataSet2.PessoaFisica);
            // TODO: This line of code loads data into the 'sysContratoDataSet2.Pessoa' table. You can move, or remove it, as needed.
            this.pessoaTableAdapter.Fill(this.sysContratoDataSet2.Pessoa);
            // TODO: This line of code loads data into the 'sysContratoDataSet1.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.sysContratoDataSet1.Cliente);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cliente.CPF = HelperFormatacao.RemoverFormatacao(cPFTextBox.Text);
            _repositorioCliente = new RepositorioCliente();

            if (_repositorioCliente.CPFExiste(cliente.CPF))
            {
                MessageBox.Show("Este CPF já está cadastrado!");
            }
            else
            {
                _repositorioCliente.Inserir(cliente);
                ListarCliente();
            }
        }


        private void ListarCliente()
        {
            if (_repositorioCliente == null)
            {
                _repositorioCliente = new RepositorioCliente();

            }
            clientedataGridView.DataSource = _repositorioCliente.Pesquisa();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _repositorioCliente = new RepositorioCliente();

            // var excluirCliente = new Cliente();
            try
            {
                //excluirCliente = clientedataGridView.SelectedRows[0].DataBoundItem as Cliente;
                //if (_repositorioCliente.ClienteTemContrato((Convert.ToInt32(clientedataGridView.CurrentRow.Cells[0].Value))))

                cliente = _repositorioCliente.PesquisarPorId(Convert.ToInt32(clientedataGridView.CurrentRow.Cells[0].Value));

                if (_repositorioCliente.ClienteTemContrato((Convert.ToInt32(cliente.Id))))
                {
                    MessageBox.Show("Este cliente contem contrato");
                }
                else
                {
                    HelperMensagem.confirmaExclusao("Deseja excluir?", "Exclussão", MessageBoxButtons.YesNo);
                    if (HelperMensagem.resultado == DialogResult.Yes)
                    {
                        _repositorioCliente.Excluir(cliente);
                    }

                }
                ListarCliente();
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível reliazar a exclussão " + ex.Message);
            }

            ListarCliente();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                FClienteEdicao fClienteEdicao = new FClienteEdicao();
                fClienteEdicao.ClienteId = (clientedataGridView.CurrentRow.DataBoundItem as Cliente).Id;
                fClienteEdicao.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível acessar a rotina " + ex.Message);
            }
            ListarCliente();
        }

        private void cPFTextBox_Validating(object sender, CancelEventArgs e)
        {
            if ((HelperFormatacao.FormataCPFCNPJ(cPFTextBox.Text).Length != 11) && (HelperFormatacao.FormataCPFCNPJ(cPFTextBox.Text).Length != 14))
            {
                MessageBox.Show("CPF ou CNPJ inváildo!");
                cPFTextBox.Focus();
                cPFTextBox.Clear();
            } else
            {
              cPFTextBox.Text = HelperFormatacao.FormataCPFCNPJ(cPFTextBox.Text);
            }
        }

        private void cPFTextBox_Enter(object sender, EventArgs e)
        {
            cPFTextBox.Text = HelperFormatacao.RemoverFormatacao(cPFTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

           //    _pf = new RepositorioBase<PessoaFisica>();

              //     _pf.Inserir(pessoaFisca);


           _pJ = new RepositorioBase<PessoaJuridica>();



           
            _pJ.Inserir(pessoaJuridica);

        }
    }
}
