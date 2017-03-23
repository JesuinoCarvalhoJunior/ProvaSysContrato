namespace Prova.SysContrato.View
{
    partial class FCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label nomeLabel1;
            System.Windows.Forms.Label cpfLabel1;
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPesquisaCodigo = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataNascimentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clientedataGridView = new System.Windows.Forms.DataGridView();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.sysContratoDataSet1 = new Prova.SysContrato.SysContratoDataSet1();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Prova.SysContrato.SysContratoDataSet1TableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new Prova.SysContrato.SysContratoDataSet1TableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.sysContratoDataSet2 = new Prova.SysContrato.SysContratoDataSet2();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new Prova.SysContrato.SysContratoDataSet2TableAdapters.PessoaTableAdapter();
            this.tableAdapterManager1 = new Prova.SysContrato.SysContratoDataSet2TableAdapters.TableAdapterManager();
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pessoaFisicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaFisicaTableAdapter = new Prova.SysContrato.SysContratoDataSet2TableAdapters.PessoaFisicaTableAdapter();
            this.cpfTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            nomeLabel1 = new System.Windows.Forms.Label();
            cpfLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysContratoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysContratoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaFisicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(316, 36);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataNascimentoLabel.TabIndex = 17;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(23, 10);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 15;
            nomeLabel.Text = "Nome:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(386, 394);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 25);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(275, 394);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(168, 394);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 25);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(54, 394);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 25);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPesquisaCodigo);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.textBoxPesquisa);
            this.groupBox1.Controls.Add(this.comboBoxFiltro);
            this.groupBox1.Location = new System.Drawing.Point(26, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:";
            // 
            // textBoxPesquisaCodigo
            // 
            this.textBoxPesquisaCodigo.Location = new System.Drawing.Point(81, 21);
            this.textBoxPesquisaCodigo.Name = "textBoxPesquisaCodigo";
            this.textBoxPesquisaCodigo.Size = new System.Drawing.Size(320, 20);
            this.textBoxPesquisaCodigo.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(407, 18);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(81, 21);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(320, 20);
            this.textBoxPesquisa.TabIndex = 1;
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Todos",
            "Código",
            "Nome"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(6, 19);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(69, 21);
            this.comboBoxFiltro.TabIndex = 0;
            // 
            // dataNascimentoMaskedTextBox
            // 
            this.dataNascimentoMaskedTextBox.Location = new System.Drawing.Point(414, 33);
            this.dataNascimentoMaskedTextBox.Mask = "00/00/0000";
            this.dataNascimentoMaskedTextBox.Name = "dataNascimentoMaskedTextBox";
            this.dataNascimentoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataNascimentoMaskedTextBox.TabIndex = 20;
            this.dataNascimentoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // clientedataGridView
            // 
            this.clientedataGridView.AllowUserToAddRows = false;
            this.clientedataGridView.AllowUserToDeleteRows = false;
            this.clientedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientedataGridView.Location = new System.Drawing.Point(26, 76);
            this.clientedataGridView.Name = "clientedataGridView";
            this.clientedataGridView.ReadOnly = true;
            this.clientedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientedataGridView.Size = new System.Drawing.Size(488, 230);
            this.clientedataGridView.TabIndex = 18;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(67, 7);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(447, 20);
            this.nomeTextBox.TabIndex = 16;
            // 
            // sysContratoDataSet1
            // 
            this.sysContratoDataSet1.DataSetName = "SysContratoDataSet1";
            this.sysContratoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.sysContratoDataSet1;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Prova.SysContrato.SysContratoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 451);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 20);
            this.textBox1.TabIndex = 23;
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(31, 36);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 23;
            cPFLabel.Text = "CPF:";
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(67, 33);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(100, 20);
            this.cPFTextBox.TabIndex = 24;
            this.cPFTextBox.Enter += new System.EventHandler(this.cPFTextBox_Enter);
            this.cPFTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cPFTextBox_Validating);
            // 
            // sysContratoDataSet2
            // 
            this.sysContratoDataSet2.DataSetName = "SysContratoDataSet2";
            this.sysContratoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            this.pessoaBindingSource.DataSource = this.sysContratoDataSet2;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PessoaFisicaTableAdapter = this.pessoaFisicaTableAdapter;
            this.tableAdapterManager1.PessoaJuridicaTableAdapter = null;
            this.tableAdapterManager1.PessoaTableAdapter = this.pessoaTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Prova.SysContrato.SysContratoDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomeLabel1
            // 
            nomeLabel1.AutoSize = true;
            nomeLabel1.Location = new System.Drawing.Point(628, 118);
            nomeLabel1.Name = "nomeLabel1";
            nomeLabel1.Size = new System.Drawing.Size(38, 13);
            nomeLabel1.TabIndex = 24;
            nomeLabel1.Text = "Nome:";
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pessoaBindingSource, "Nome", true));
            this.nomeTextEdit.Location = new System.Drawing.Point(672, 115);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nomeTextEdit.TabIndex = 25;
            // 
            // pessoaFisicaBindingSource
            // 
            this.pessoaFisicaBindingSource.DataMember = "FKFCEA32D919D474";
            this.pessoaFisicaBindingSource.DataSource = this.pessoaBindingSource;
            // 
            // pessoaFisicaTableAdapter
            // 
            this.pessoaFisicaTableAdapter.ClearBeforeFill = true;
            // 
            // cpfLabel1
            // 
            cpfLabel1.AutoSize = true;
            cpfLabel1.Location = new System.Drawing.Point(640, 163);
            cpfLabel1.Name = "cpfLabel1";
            cpfLabel1.Size = new System.Drawing.Size(26, 13);
            cpfLabel1.TabIndex = 25;
            cpfLabel1.Text = "Cpf:";
            // 
            // cpfTextEdit
            // 
            this.cpfTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pessoaFisicaBindingSource, "Cpf", true));
            this.cpfTextEdit.Location = new System.Drawing.Point(672, 160);
            this.cpfTextEdit.Name = "cpfTextEdit";
            this.cpfTextEdit.Size = new System.Drawing.Size(100, 20);
            this.cpfTextEdit.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(cpfLabel1);
            this.Controls.Add(this.cpfTextEdit);
            this.Controls.Add(nomeLabel1);
            this.Controls.Add(this.nomeTextEdit);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoMaskedTextBox);
            this.Controls.Add(this.clientedataGridView);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FCliente";
            this.Text = "FCliente";
            this.Load += new System.EventHandler(this.FCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysContratoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysContratoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaFisicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPesquisaCodigo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.MaskedTextBox dataNascimentoMaskedTextBox;
        public System.Windows.Forms.DataGridView clientedataGridView;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SysContratoDataSet1 sysContratoDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private SysContratoDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private SysContratoDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cPFTextBox;
        private SysContratoDataSet2 sysContratoDataSet2;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private SysContratoDataSet2TableAdapters.PessoaTableAdapter pessoaTableAdapter;
        private SysContratoDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private SysContratoDataSet2TableAdapters.PessoaFisicaTableAdapter pessoaFisicaTableAdapter;
        private DevExpress.XtraEditors.TextEdit nomeTextEdit;
        private System.Windows.Forms.BindingSource pessoaFisicaBindingSource;
        private DevExpress.XtraEditors.TextEdit cpfTextEdit;
        private System.Windows.Forms.Button button1;
    }
}