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
    public partial class FPessoaEdicao : Form
    {

        private int pessoaId;
        private RepositorioPessoaFisica _repositorioPessoaFisica;
        private Pessoa _pessoaFisca;
       // private PessoaFisica pessoaFisca = new PessoaFisica();

        public FPessoaEdicao()
        {
            InitializeComponent();

            pessoaFisicaBindingSource.DataSource = _pessoaFisca;
            _repositorioPessoaFisica = new RepositorioPessoaFisica();
            PesquisaPessoaId();
        }

        public int PessoaId
        {
            get { return pessoaId; }
            set
            {
                pessoaId = value;
                PesquisaPessoaId();
            }
        }

        private void PesquisaPessoaId()
        {
            _pessoaFisca = _repositorioPessoaFisica.PesquisarPorId(PessoaId);

            pessoaFisicaBindingSource.DataSource = _pessoaFisca;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _repositorioPessoaFisica.Alterar(_pessoaFisca);
            FCliente fCliente  = new FCliente();
            fCliente.ListarCliente();
            this.Close();
        }
    }
}
