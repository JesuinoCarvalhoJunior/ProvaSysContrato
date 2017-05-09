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
    public partial class FPessoaJuridica : Form
    {
        private RepositorioPessoaJuridica _repositorioPessoaJuridica;

        private PessoaJuridica pessoaJuridica = new PessoaJuridica();
        public FPessoaJuridica()
        {
            InitializeComponent();

            pessoaBindingSource.DataSource = pessoaJuridica;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HelperFormatacao.RemoverFormatacao(textBoxCnpj.Text).Length == 14)
            {
                _repositorioPessoaJuridica = new RepositorioPessoaJuridica();

                pessoaJuridica.Cnpj = HelperFormatacao.RemoverFormatacao(textBoxCnpj.Text);

                // pessoaJuridica.Nome = nomeTextEdit.Text;

                if (_repositorioPessoaJuridica.CNPJExiste(pessoaJuridica.Cnpj))
                {
                    MessageBox.Show("Este CNPJ já está cadastrado!");
                }
                else
                    //   {
                    _repositorioPessoaJuridica.Inserir(pessoaJuridica);
                //  ListarCliente();
                //  }
                //  pessoaJuridicaBindingSource.DataSource = pessoaJuridica;
            }
        }
    }
}
