namespace Prova.SysContrato.View
{
    partial class FContrato
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
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label dataInicioLabel;
            System.Windows.Forms.Label dataFimLabel;
            this.sysContratoDataSet = new Prova.SysContrato.SysContratoDataSet();
            this.contratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratoTableAdapter = new Prova.SysContrato.SysContratoDataSetTableAdapters.ContratoTableAdapter();
            this.tableAdapterManager = new Prova.SysContrato.SysContratoDataSetTableAdapters.TableAdapterManager();
            this.numeroTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descricaoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.valorSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.contratoDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.sysContratoDataSet1 = new Prova.SysContrato.SysContratoDataSet1();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Prova.SysContrato.SysContratoDataSet1TableAdapters.ClienteTableAdapter();
            this.tableAdapterManager1 = new Prova.SysContrato.SysContratoDataSet1TableAdapters.TableAdapterManager();
            this.nomeComboBox = new System.Windows.Forms.ComboBox();
            this.dataInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataFimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clienteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            numeroLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            dataInicioLabel = new System.Windows.Forms.Label();
            dataFimLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sysContratoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descricaoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysContratoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(32, 24);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 1;
            numeroLabel.Text = "Numero:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(21, 62);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 2;
            descricaoLabel.Text = "Descricao:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(307, 24);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 4;
            valorLabel.Text = "Valor:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(41, 147);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 19;
            nomeLabel.Text = "Nome:";
            // 
            // sysContratoDataSet
            // 
            this.sysContratoDataSet.DataSetName = "SysContratoDataSet";
            this.sysContratoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contratoBindingSource
            // 
            this.contratoBindingSource.DataMember = "Contrato";
            this.contratoBindingSource.DataSource = this.sysContratoDataSet;
            // 
            // contratoTableAdapter
            // 
            this.contratoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContratoTableAdapter = this.contratoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Prova.SysContrato.SysContratoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numeroTextEdit
            // 
            this.numeroTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contratoBindingSource, "Numero", true));
            this.numeroTextEdit.Location = new System.Drawing.Point(85, 21);
            this.numeroTextEdit.Name = "numeroTextEdit";
            this.numeroTextEdit.Size = new System.Drawing.Size(100, 20);
            this.numeroTextEdit.TabIndex = 2;
            // 
            // descricaoTextEdit
            // 
            this.descricaoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contratoBindingSource, "Descricao", true));
            this.descricaoTextEdit.Location = new System.Drawing.Point(85, 59);
            this.descricaoTextEdit.Name = "descricaoTextEdit";
            this.descricaoTextEdit.Size = new System.Drawing.Size(362, 20);
            this.descricaoTextEdit.TabIndex = 3;
            // 
            // valorSpinEdit
            // 
            this.valorSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contratoBindingSource, "Valor", true));
            this.valorSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.valorSpinEdit.Location = new System.Drawing.Point(347, 21);
            this.valorSpinEdit.Name = "valorSpinEdit";
            this.valorSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.valorSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.valorSpinEdit.TabIndex = 5;
            // 
            // contratoDataGridView
            // 
            this.contratoDataGridView.AutoGenerateColumns = false;
            this.contratoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contratoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.dataInicioDataGridViewTextBoxColumn,
            this.dataFimDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.clienteidDataGridViewTextBoxColumn});
            this.contratoDataGridView.DataSource = this.contratoBindingSource;
            this.contratoDataGridView.Location = new System.Drawing.Point(21, 195);
            this.contratoDataGridView.Name = "contratoDataGridView";
            this.contratoDataGridView.Size = new System.Drawing.Size(539, 150);
            this.contratoDataGridView.TabIndex = 10;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(383, 374);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 25);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(272, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(165, 374);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 25);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(51, 374);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 25);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // sysContratoDataSet1
            // 
            this.sysContratoDataSet1.DataSetName = "SysContratoDataSet1";
            this.sysContratoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.sysContratoDataSet1;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Prova.SysContrato.SysContratoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomeComboBox
            // 
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "Id", true));
            this.nomeComboBox.DataSource = this.clienteBindingSource;
            this.nomeComboBox.DisplayMember = "Nome";
            this.nomeComboBox.FormattingEnabled = true;
            this.nomeComboBox.Location = new System.Drawing.Point(85, 144);
            this.nomeComboBox.Name = "nomeComboBox";
            this.nomeComboBox.Size = new System.Drawing.Size(362, 21);
            this.nomeComboBox.TabIndex = 20;
            this.nomeComboBox.ValueMember = "Id";
            // 
            // dataInicioLabel
            // 
            dataInicioLabel.AutoSize = true;
            dataInicioLabel.Location = new System.Drawing.Point(18, 99);
            dataInicioLabel.Name = "dataInicioLabel";
            dataInicioLabel.Size = new System.Drawing.Size(61, 13);
            dataInicioLabel.TabIndex = 20;
            dataInicioLabel.Text = "Data Inicio:";
            // 
            // dataInicioDateTimePicker
            // 
            this.dataInicioDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dataInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratoBindingSource, "DataInicio", true));
            this.dataInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataInicioDateTimePicker.Location = new System.Drawing.Point(85, 95);
            this.dataInicioDateTimePicker.Name = "dataInicioDateTimePicker";
            this.dataInicioDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.dataInicioDateTimePicker.TabIndex = 21;
            // 
            // dataFimLabel
            // 
            dataFimLabel.AutoSize = true;
            dataFimLabel.Location = new System.Drawing.Point(289, 99);
            dataFimLabel.Name = "dataFimLabel";
            dataFimLabel.Size = new System.Drawing.Size(52, 13);
            dataFimLabel.TabIndex = 21;
            dataFimLabel.Text = "Data Fim:";
            // 
            // dataFimDateTimePicker
            // 
            this.dataFimDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dataFimDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratoBindingSource, "DataFim", true));
            this.dataFimDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataFimDateTimePicker.Location = new System.Drawing.Point(347, 95);
            this.dataFimDateTimePicker.Name = "dataFimDateTimePicker";
            this.dataFimDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.dataFimDateTimePicker.TabIndex = 22;
            // 
            // clienteidDataGridViewTextBoxColumn
            // 
            this.clienteidDataGridViewTextBoxColumn.DataPropertyName = "Cliente_id";
            this.clienteidDataGridViewTextBoxColumn.HeaderText = "Cliente_id";
            this.clienteidDataGridViewTextBoxColumn.Name = "clienteidDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // dataFimDataGridViewTextBoxColumn
            // 
            this.dataFimDataGridViewTextBoxColumn.DataPropertyName = "DataFim";
            this.dataFimDataGridViewTextBoxColumn.HeaderText = "DataFim";
            this.dataFimDataGridViewTextBoxColumn.Name = "dataFimDataGridViewTextBoxColumn";
            // 
            // dataInicioDataGridViewTextBoxColumn
            // 
            this.dataInicioDataGridViewTextBoxColumn.DataPropertyName = "DataInicio";
            this.dataInicioDataGridViewTextBoxColumn.HeaderText = "DataInicio";
            this.dataInicioDataGridViewTextBoxColumn.Name = "dataInicioDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 468);
            this.Controls.Add(dataFimLabel);
            this.Controls.Add(this.dataFimDateTimePicker);
            this.Controls.Add(dataInicioLabel);
            this.Controls.Add(this.dataInicioDateTimePicker);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeComboBox);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.contratoDataGridView);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorSpinEdit);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextEdit);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextEdit);
            this.Name = "FContrato";
            this.Text = "FContrato";
            this.Load += new System.EventHandler(this.FContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysContratoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descricaoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysContratoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SysContratoDataSet sysContratoDataSet;
        private System.Windows.Forms.BindingSource contratoBindingSource;
        private SysContratoDataSetTableAdapters.ContratoTableAdapter contratoTableAdapter;
        private SysContratoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit numeroTextEdit;
        private DevExpress.XtraEditors.TextEdit descricaoTextEdit;
        private DevExpress.XtraEditors.SpinEdit valorSpinEdit;
        private System.Windows.Forms.DataGridView contratoDataGridView;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private SysContratoDataSet1 sysContratoDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SysContratoDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private SysContratoDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox nomeComboBox;
        private System.Windows.Forms.DateTimePicker dataInicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataFimDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteidDataGridViewTextBoxColumn;
    }
}