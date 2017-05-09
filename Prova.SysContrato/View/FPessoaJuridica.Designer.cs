namespace Prova.SysContrato.View
{
    partial class FPessoaJuridica
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
            System.Windows.Forms.Label nomeLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.textBoxCnpj = new System.Windows.Forms.TextBox();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pessoaBindingSource
            // 
       //     this.pessoaBindingSource.DataSource = typeof(SysContrato.Dominio.Entidade.Pessoa);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(125, 94);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 28;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pessoaBindingSource, "Nome", true));
            this.nomeTextEdit.Location = new System.Drawing.Point(169, 91);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nomeTextEdit.TabIndex = 29;
            // 
            // textBoxCnpj
            // 
            this.textBoxCnpj.Location = new System.Drawing.Point(169, 118);
            this.textBoxCnpj.Name = "textBoxCnpj";
            this.textBoxCnpj.Size = new System.Drawing.Size(100, 20);
            this.textBoxCnpj.TabIndex = 30;
            // 
            // FPessoaJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 395);
            this.Controls.Add(this.textBoxCnpj);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextEdit);
            this.Controls.Add(this.button1);
            this.Name = "FPessoaJuridica";
            this.Text = "FPessoaJuridica";
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private DevExpress.XtraEditors.TextEdit nomeTextEdit;
        private System.Windows.Forms.TextBox textBoxCnpj;
    }
}