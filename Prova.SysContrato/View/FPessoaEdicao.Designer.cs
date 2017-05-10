namespace Prova.SysContrato.View
{
    partial class FPessoaEdicao
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label nomeLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.pessoaFisicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dataNascimentoDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            idLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaFisicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNascimentoDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNascimentoDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(94, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(305, 74);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(26, 13);
            cpfLabel.TabIndex = 3;
            cpfLabel.Text = "Cpf:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(21, 74);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataNascimentoLabel.TabIndex = 5;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(75, 48);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 7;
            nomeLabel.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaFisicaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(119, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // cpfTextEdit
            // 
            this.cpfTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pessoaFisicaBindingSource, "Cpf", true));
            this.cpfTextEdit.Location = new System.Drawing.Point(337, 71);
            this.cpfTextEdit.Name = "cpfTextEdit";
            this.cpfTextEdit.Size = new System.Drawing.Size(100, 20);
            this.cpfTextEdit.TabIndex = 4;
            // 
            // dataNascimentoDateEdit
            // 
            this.dataNascimentoDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pessoaFisicaBindingSource, "DataNascimento", true));
            this.dataNascimentoDateEdit.EditValue = null;
            this.dataNascimentoDateEdit.Location = new System.Drawing.Point(119, 71);
            this.dataNascimentoDateEdit.Name = "dataNascimentoDateEdit";
            this.dataNascimentoDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataNascimentoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataNascimentoDateEdit.Size = new System.Drawing.Size(100, 20);
            this.dataNascimentoDateEdit.TabIndex = 6;
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pessoaFisicaBindingSource, "Nome", true));
            this.nomeTextEdit.Location = new System.Drawing.Point(119, 45);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(318, 20);
            this.nomeTextEdit.TabIndex = 8;
            // 
            // FPessoaEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 339);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextEdit);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoDateEdit);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.cpfTextEdit);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.button1);
            this.Name = "FPessoaEdicao";
            this.Text = "FPessoaEdicao";
            ((System.ComponentModel.ISupportInitialize)(this.pessoaFisicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNascimentoDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNascimentoDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pessoaFisicaBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private DevExpress.XtraEditors.TextEdit cpfTextEdit;
        private DevExpress.XtraEditors.DateEdit dataNascimentoDateEdit;
        private DevExpress.XtraEditors.TextEdit nomeTextEdit;
    }
}