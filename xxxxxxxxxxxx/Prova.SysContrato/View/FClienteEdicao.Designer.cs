namespace Prova.SysContrato.View
{
    partial class FClienteEdicao
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
            this.button1 = new System.Windows.Forms.Button();
            this.sysContratoDataSet1 = new Prova.SysContrato.SysContratoDataSet1();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Prova.SysContrato.SysContratoDataSet1TableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new Prova.SysContrato.SysContratoDataSet1TableAdapters.TableAdapterManager();
            this.cPFTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            cPFLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sysContratoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPFTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Prova.SysContrato.SysContratoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(61, 110);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 29;
            cPFLabel.Text = "CPF:";
            // 
            // cPFTextEdit
            // 
            this.cPFTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "CPF", true));
            this.cPFTextEdit.Location = new System.Drawing.Point(97, 107);
            this.cPFTextEdit.Name = "cPFTextEdit";
            this.cPFTextEdit.Size = new System.Drawing.Size(100, 20);
            this.cPFTextEdit.TabIndex = 30;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(53, 64);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 30;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "Nome", true));
            this.nomeTextEdit.Location = new System.Drawing.Point(97, 61);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(408, 20);
            this.nomeTextEdit.TabIndex = 31;
            // 
            // FClienteEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 420);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextEdit);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextEdit);
            this.Controls.Add(this.button1);
            this.Name = "FClienteEdicao";
            this.Text = "FClienteEdicao";
            this.Load += new System.EventHandler(this.FClienteEdicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysContratoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPFTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private SysContratoDataSet1 sysContratoDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SysContratoDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private SysContratoDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit cPFTextEdit;
        private DevExpress.XtraEditors.TextEdit nomeTextEdit;
    }
}