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
    public partial class FPessoa : Form
    {


        private RepositorioPessoa _repositorioPessoa;
        private RepositorioBase<Pessoa> _repositorioBasePessoa;

        private RepositorioBase<PessoaFisica> _pf;
        private RepositorioBase<PessoaJuridica> _pJ;

        private PessoaFisica pessoaFisca = new PessoaFisica();
        private PessoaJuridica pessoaJuridica = new PessoaJuridica();

        private PessoaFisica pf = new PessoaFisica();
        private PessoaJuridica pj = new PessoaJuridica();

        public FPessoa()
        {
            InitializeComponent();

            pessoaBindingSource1.DataSource = ListarPessoas();
        }

   
        private IList<Pessoa> ListarPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            if (_repositorioBasePessoa == null)
            {
                _repositorioBasePessoa = new RepositorioBase<Pessoa>();

            }
            pessoaDataGridView.DataSource = _repositorioBasePessoa.Pesquisa();
            return pessoas;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
