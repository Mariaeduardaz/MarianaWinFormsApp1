namespace MarianaWinFormsApp1.ModuloMateria
{
    partial class CadastroMateria
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.comboBoxSerieMateria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDisciplinaMateria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeMateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroMateria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(284, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 54);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(167, 375);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(111, 54);
            this.btnGravar.TabIndex = 51;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // comboBoxSerieMateria
            // 
            this.comboBoxSerieMateria.FormattingEnabled = true;
            this.comboBoxSerieMateria.Items.AddRange(new object[] {
            "1 serie",
            "2 serie",
            "3 serie"});
            this.comboBoxSerieMateria.Location = new System.Drawing.Point(125, 292);
            this.comboBoxSerieMateria.Name = "comboBoxSerieMateria";
            this.comboBoxSerieMateria.Size = new System.Drawing.Size(250, 33);
            this.comboBoxSerieMateria.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(125, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 30);
            this.label8.TabIndex = 49;
            this.label8.Text = "Cadastro de matéria";
            // 
            // comboBoxDisciplinaMateria
            // 
            this.comboBoxDisciplinaMateria.FormattingEnabled = true;
            this.comboBoxDisciplinaMateria.Items.AddRange(new object[] {
            "Historia",
            "Matematica",
            "Portugues ",
            "Filosofia"});
            this.comboBoxDisciplinaMateria.Location = new System.Drawing.Point(125, 220);
            this.comboBoxDisciplinaMateria.Name = "comboBoxDisciplinaMateria";
            this.comboBoxDisciplinaMateria.Size = new System.Drawing.Size(250, 33);
            this.comboBoxDisciplinaMateria.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Série:";
            // 
            // txtNomeMateria
            // 
            this.txtNomeMateria.Location = new System.Drawing.Point(125, 142);
            this.txtNomeMateria.Name = "txtNomeMateria";
            this.txtNomeMateria.Size = new System.Drawing.Size(250, 31);
            this.txtNomeMateria.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Disciplina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nome:";
            // 
            // txtNumeroMateria
            // 
            this.txtNumeroMateria.Location = new System.Drawing.Point(125, 72);
            this.txtNumeroMateria.Name = "txtNumeroMateria";
            this.txtNumeroMateria.Size = new System.Drawing.Size(250, 31);
            this.txtNumeroMateria.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Número:";
            // 
            // CadastroMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.comboBoxSerieMateria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxDisciplinaMateria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroMateria);
            this.Controls.Add(this.label1);
            this.Name = "CadastroMateria";
            this.Text = "CadastroMateria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.ComboBox comboBoxSerieMateria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDisciplinaMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroMateria;
        private System.Windows.Forms.Label label1;
    }
}