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
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
using System.Globalization;
using DevExpress.XtraGrid.Views.Grid;

namespace Prova.SysContrato.View
{
    public partial class FCliente : Form
    {

        private RepositorioCliente _repositorioCliente;
        public Cliente cliente = new Cliente();
        public int IdCliente;


        private RepositorioBase<Pessoa> _repositorioBasePessoa;

        private RepositorioPessoaFisica _repositorioPessoaFisica;
        private RepositorioPessoaJuridica _repositorioPessoaJuridica;

        private PessoaFisica pessoaFisca = new PessoaFisica();
        private PessoaJuridica pessoaJuridica = new PessoaJuridica();
        RepositorioPessoa _repositorioPessoa = new RepositorioPessoa();

        public FCliente()
        {
            InitializeComponent();
            clienteBindingSource.DataSource = cliente;

            pessoaFisicaBindingSource.DataSource = pessoaFisca;

            ListarCliente();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (_repositorioPessoa == null)
            {
                _repositorioBasePessoa = new RepositorioBase<Pessoa>();
                RepositorioPessoa _repositorioPessoa = new RepositorioPessoa();
            }

            pessoaDataGridView.DataSource = _repositorioPessoa.PesquisarPorNome(textBoxPesquisa.Text);
        }

        private void FCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (HelperFormatacao.RemoverFormatacao(textBoxCpfCnpj.Text).Length == 11)
            {
                _repositorioPessoaFisica = new RepositorioPessoaFisica();
                pessoaFisca.Cpf = HelperFormatacao.RemoverFormatacao(textBoxCpfCnpj.Text);

                if (_repositorioPessoaFisica.CPFExiste(pessoaFisca.Cpf))
                {
                    MessageBox.Show("Este CPF já está cadastrado!");
                }
                else
                {
                    RepositorioTelefone _repositorioTelefone = new RepositorioTelefone();

                    Telefone tel = new Telefone();
                    tel.CodigoDdd = 65;
                    tel.Numero = "33";
                    tel.Principal = true;
                    
                   // pessoaFisca.Telefones.Add(new Telefone()
                   // {
                   //     CodigoDdd = 65,
                   //     Numero = "123456789"
                  //  });

                    _repositorioPessoaFisica.Inserir(pessoaFisca);

                    _repositorioTelefone.Inserir(tel); ;
                    ListarCliente();
                }
            }
            else
            {
                if (HelperFormatacao.RemoverFormatacao(textBoxCpfCnpj.Text).Length == 14)
                {
                    PessoaJuridica pessoaJuridica = new PessoaJuridica();

                    pessoaBindingSource.DataSource = pessoaJuridica;

                    _repositorioPessoaJuridica = new RepositorioPessoaJuridica();

                    pessoaJuridica.Cnpj = HelperFormatacao.RemoverFormatacao(textBoxCpfCnpj.Text);


                    if (_repositorioPessoaJuridica.CNPJExiste(pessoaJuridica.Cnpj))
                    {
                        MessageBox.Show("Este CNPJ já está cadastrado!");
                    }
                    else
                        //   {
                        _repositorioPessoaJuridica.Inserir(pessoaJuridica);
                    ListarCliente();
                    //  }

                }
            }
        }

        public void ListarCliente()
        {
            if (_repositorioBasePessoa == null)
            {
                _repositorioBasePessoa = new RepositorioBase<Pessoa>();

            }
            pessoaDataGridView.DataSource = _repositorioBasePessoa.Pesquisa();
            gridControl1.DataSource = _repositorioBasePessoa.Pesquisa();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _repositorioCliente = new RepositorioCliente();

            // var excluirCliente = new Cliente();
            try
            {
                //excluirCliente = clientedataGridView.SelectedRows[0].DataBoundItem as Cliente;
                //if (_repositorioCliente.ClienteTemContrato((Convert.ToInt32(clientedataGridView.CurrentRow.Cells[0].Value))))

                //  cliente = _repositorioCliente.PesquisarPorId(Convert.ToInt32(clientedataGridView.CurrentRow.Cells[0].Value));

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
                // FPessoaEdicao.PessoaId = (pessoaDataGridView.CurrentRow.DataBoundItem as PessoaFisica).Id;
                //  HelperOpenScreen.AbrirFormulario<FPessoaEdicao>();

                FPessoaEdicao FPessoaEdicao = new FPessoaEdicao();
                FPessoaEdicao.PessoaId = (pessoaDataGridView.CurrentRow.DataBoundItem as PessoaFisica).Id;
                FPessoaEdicao.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível acessar a rotina " + ex.Message);
            }
        }

        // try
        // {
        //   FClienteEdicao fClienteEdicao = new FClienteEdicao();
        ///     fClienteEdicao.ClienteId = (clientedataGridView.CurrentRow.DataBoundItem as Cliente).Id;
        //   fClienteEdicao.ShowDialog();
        //  }
        //  catch (Exception ex)
        // {
        //   throw new Exception("Não foi possível acessar a rotina " + ex.Message);
        //}
        //    ListarCliente();
        //




        private void clientedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void textBoxCpfCnpj_Validating(object sender, CancelEventArgs e)
        {
            if (HelperFormatacao.RemoverFormatacao(textBoxCpfCnpj.Text).Length == 11)
            {
                //  pessoaFisicaBindingSource = new BindingSource();
                // _repositorioPessoaFisica = new RepositorioPessoaFisica();

                if (HelperFormatacao.RemoverFormatacao(textBoxCpfCnpj.Text).Length == 11)
                {
                    // preenche grid
                    //   pessoaDataGridView.DataSource = _repositorioPessoaFisica.PesquisarPorCPF(textBoxCpfCnpj.Text);

                    if (_repositorioPessoaFisica == null)
                    {
                        _repositorioPessoaFisica = new RepositorioPessoaFisica();
                    }

                    pessoaFisicaBindingSource.DataSource = _repositorioPessoaFisica.PesquisarPorCPF(HelperFormatacao.RemoverFormatacao(textBoxCpfCnpj.Text));
                    pessoaDataGridView.DataSource = pessoaFisicaBindingSource.DataSource;

                    if (_repositorioPessoaFisica.CPFExiste(HelperFormatacao.RemoverFormatacao(textBoxCpfCnpj.Text)))
                    {
                        try
                        {
                            FPessoaEdicao FPessoaEdicao = new FPessoaEdicao();
                            FPessoaEdicao.PessoaId = (pessoaDataGridView.CurrentRow.DataBoundItem as PessoaFisica).Id;
                            FPessoaEdicao.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Não foi possível acessar a rotina " + ex.Message);
                        }
                    }

                }


                if (_repositorioPessoa == null)
                {
                    _repositorioBasePessoa = new RepositorioBase<Pessoa>();
                    RepositorioPessoa _repositorioPessoa = new RepositorioPessoa();
                }

                pessoaDataGridView.DataSource = _repositorioPessoa.PesquisarPorNome(textBoxPesquisa.Text);


            }
            else
            {
                PessoaJuridica pessoaJuridica = new PessoaJuridica();
                pessoaJuridicaBindingSource.DataSource = pessoaJuridica;
            }

            // if ((HelperFormatacao.FormataCPFCNPJ(textBoxCpfCnpj.Text).Length != 11) && (HelperFormatacao.FormataCPFCNPJ(textBoxCpfCnpj.Text).Length != 14))
            //{
            //     MessageBox.Show("CPF ou CNPJ inváildo!");
            //     textBoxCpfCnpj.Focus();
            //     textBoxCpfCnpj.Clear();
            // }
            // else
            // {
            textBoxCpfCnpj.Text = HelperFormatacao.FormataCPFCNPJ(textBoxCpfCnpj.Text);
            //}
        }

        private void textBoxCpfCnpj_Validating_1(object sender, CancelEventArgs e)
        {
            if (HelperFormatacao.RemoverFormatacao(textBoxCpfCnpj.Text).Length == 14)
            {
                using (FPessoaJuridica Fcliente = new FPessoaJuridica())
                {
                    try
                    {
                        HelperOpenScreen.AbrirFormulario<FPessoaJuridica>();
                        // Fcliente.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Não foi possível acessar a rotina " + ex.Message);
                    }
                }
            }
        }

        private void textBoxCpfCnpj_Enter(object sender, EventArgs e)
        {
            textBoxCpfCnpj.Text = HelperFormatacao.RemoverFormatacao(textBoxCpfCnpj.Text);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void pessoaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            double d;
            // Aqui vem a coluna com os dados, no meu caso é a coluna 1
            if (e.ColumnIndex == 3)
            {
                // Vejo se tem algo preenchido e eu estou convertendo
                // para Double para aplicar uma máscara numérica
                if (e.Value != null &&
                Double.TryParse(e.Value.ToString(), out d))
                {
                    Console.WriteLine(e.Value.ToString().Length);
                    // Se for até 11 caracteres, considero CPF
                    if (e.Value.ToString().Length <= 11)
                        e.Value = d.ToString("###'.'###'.'###-##");
                    // De 12 a 14, CNPJ
                    else if (e.Value.ToString().Length > 11 &&
                    e.Value.ToString().Length <= 14)
                        e.Value = d.ToString("##'.'###'.'###/####-##");


                }
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {

            if (e.Column.FieldName != "CPFCNPJ")  return;


            string DisplayTextTel = (e.Value != null) ? e.Value.ToString() : "";

            if ( e.Column.FieldName == "Telefones") {

               
                DisplayTextTel = (e.Value == null) ? "Sem telefone" : e.Value.ToString();
            }

            string DisplayText = (e.Value != null) ? e.Value.ToString() : "";
            try
            {
                if (DisplayText.Length == 11)
                {
                    e.DisplayText = String.Format("{0}.{1}.{2}-{3}",
                                                   DisplayText.Substring(0, 3),
                                                   DisplayText.Substring(3, 3),
                                                   DisplayText.Substring(6, 3),
                                                   DisplayText.Substring(9, 2));
                }
                else
                {
                    e.DisplayText = string.Format("{0}.{1}.{2}/{3}-{4}",
                                                   DisplayText.Substring(0, 2),
                                                   DisplayText.Substring(2, 3),
                                                   DisplayText.Substring(5, 3),
                                                   DisplayText.Substring(8, 4),
                                                   DisplayText.Substring(12, 2));
                }
            }
            catch (Exception ex)
            {
                //
            }
        }
    }
}
