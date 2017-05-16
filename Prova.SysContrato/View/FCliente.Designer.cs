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
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxCpfCnpj = new System.Windows.Forms.TextBox();
            this.pessoaJuridicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pessoaFisicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataNascimentoDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.telefoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pessoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            cPFLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaJuridicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaFisicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNascimentoDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNascimentoDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource2)).BeginInit();
            this.SuspendLayout();
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
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(23, 6);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 28;
            nomeLabel.Text = "Nome:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(316, 36);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataNascimentoLabel.TabIndex = 29;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(354, 263);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 25);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(243, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(136, 263);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 25);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(22, 263);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 25);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.textBoxPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(26, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por nome:";
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
            this.textBoxPesquisa.Location = new System.Drawing.Point(8, 20);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(393, 20);
            this.textBoxPesquisa.TabIndex = 1;
            // 
            // textBoxCpfCnpj
            // 
            this.textBoxCpfCnpj.Location = new System.Drawing.Point(67, 29);
            this.textBoxCpfCnpj.Name = "textBoxCpfCnpj";
            this.textBoxCpfCnpj.Size = new System.Drawing.Size(100, 20);
            this.textBoxCpfCnpj.TabIndex = 25;
            this.textBoxCpfCnpj.Enter += new System.EventHandler(this.textBoxCpfCnpj_Enter);
            this.textBoxCpfCnpj.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCpfCnpj_Validating);
            // 
            // pessoaDataGridView
            // 
            this.pessoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoaDataGridView.Location = new System.Drawing.Point(34, 59);
            this.pessoaDataGridView.Name = "pessoaDataGridView";
            this.pessoaDataGridView.Size = new System.Drawing.Size(488, 114);
            this.pessoaDataGridView.TabIndex = 26;
            this.pessoaDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.pessoaDataGridView_CellFormatting);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(446, 263);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 25);
            this.btnAtualizar.TabIndex = 28;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pessoaFisicaBindingSource, "Nome", true));
            this.nomeTextEdit.Location = new System.Drawing.Point(67, 3);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(447, 20);
            this.nomeTextEdit.TabIndex = 29;
            // 
            // dataNascimentoDateEdit
            // 
            this.dataNascimentoDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pessoaFisicaBindingSource, "DataNascimento", true));
            this.dataNascimentoDateEdit.EditValue = null;
            this.dataNascimentoDateEdit.Location = new System.Drawing.Point(414, 33);
            this.dataNascimentoDateEdit.Name = "dataNascimentoDateEdit";
            this.dataNascimentoDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataNascimentoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataNascimentoDateEdit.Size = new System.Drawing.Size(100, 20);
            this.dataNascimentoDateEdit.TabIndex = 30;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pessoaBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(22, 305);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(590, 170);
            this.gridControl1.TabIndex = 31;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // gridControl2
            // 
            this.gridControl2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pessoaBindingSource2, "TelefonePrincipal", true));
            this.gridControl2.DataSource = this.pessoaBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(514, 36);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(438, 287);
            this.gridControl2.TabIndex = 32;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nome";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Telefone";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Doc";
            this.gridColumn3.FieldName = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // pessoaBindingSource1
     
            // 
            // FCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 495);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoDateEdit);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextEdit);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.pessoaDataGridView);
            this.Controls.Add(this.textBoxCpfCnpj);
            this.Controls.Add(cPFLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.pessoaJuridicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaFisicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNascimentoDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNascimentoDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource pessoaJuridicaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.TextBox textBoxCpfCnpj;
        private System.Windows.Forms.DataGridView pessoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private DevExpress.XtraEditors.TextEdit nomeTextEdit;
        private System.Windows.Forms.BindingSource pessoaFisicaBindingSource;
        private DevExpress.XtraEditors.DateEdit dataNascimentoDateEdit;
        private System.Windows.Forms.BindingSource telefoneBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.BindingSource pessoaBindingSource2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.BindingSource pessoaBindingSource1;
    }
}