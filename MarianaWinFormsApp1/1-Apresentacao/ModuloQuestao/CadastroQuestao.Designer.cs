namespace MarianaWinFormsApp1.Apresentacao.ModuloQuestao
{
    partial class CadastroQuestao
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
            this.checkBoxTeste = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAlternativa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDisciplinaTeste = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCancelarTeste = new System.Windows.Forms.Button();
            this.buttonGravarTeste = new System.Windows.Forms.Button();
            this.textBoxEnunciadoTeste = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxNumeroQuestoes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.checkedListBoxAlternativa = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkBoxTeste
            // 
            this.checkBoxTeste.AutoSize = true;
            this.checkBoxTeste.Location = new System.Drawing.Point(627, 124);
            this.checkBoxTeste.Name = "checkBoxTeste";
            this.checkBoxTeste.Size = new System.Drawing.Size(182, 29);
            this.checkBoxTeste.TabIndex = 93;
            this.checkBoxTeste.Text = "Alternativa correta";
            this.checkBoxTeste.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(838, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 50);
            this.button1.TabIndex = 92;
            this.button1.Text = "Adcionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxAlternativa
            // 
            this.textBoxAlternativa.Location = new System.Drawing.Point(559, 70);
            this.textBoxAlternativa.Name = "textBoxAlternativa";
            this.textBoxAlternativa.Size = new System.Drawing.Size(250, 31);
            this.textBoxAlternativa.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 90;
            this.label1.Text = "Alternativas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(127, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 36);
            this.label8.TabIndex = 88;
            this.label8.Text = "Cadastro questão";
            // 
            // comboBoxDisciplinaTeste
            // 
            this.comboBoxDisciplinaTeste.FormattingEnabled = true;
            this.comboBoxDisciplinaTeste.Items.AddRange(new object[] {
            "Historia",
            "Matematica",
            "Portugues ",
            "Filosofia"});
            this.comboBoxDisciplinaTeste.Location = new System.Drawing.Point(127, 198);
            this.comboBoxDisciplinaTeste.Name = "comboBoxDisciplinaTeste";
            this.comboBoxDisciplinaTeste.Size = new System.Drawing.Size(224, 33);
            this.comboBoxDisciplinaTeste.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 86;
            this.label6.Text = "Disciplina:";
            // 
            // buttonCancelarTeste
            // 
            this.buttonCancelarTeste.Location = new System.Drawing.Point(314, 413);
            this.buttonCancelarTeste.Name = "buttonCancelarTeste";
            this.buttonCancelarTeste.Size = new System.Drawing.Size(112, 50);
            this.buttonCancelarTeste.TabIndex = 85;
            this.buttonCancelarTeste.Text = "Cancelar";
            this.buttonCancelarTeste.UseVisualStyleBackColor = true;
            // 
            // buttonGravarTeste
            // 
            this.buttonGravarTeste.Location = new System.Drawing.Point(169, 413);
            this.buttonGravarTeste.Name = "buttonGravarTeste";
            this.buttonGravarTeste.Size = new System.Drawing.Size(112, 50);
            this.buttonGravarTeste.TabIndex = 84;
            this.buttonGravarTeste.Text = "Gravar";
            this.buttonGravarTeste.UseVisualStyleBackColor = true;
            this.buttonGravarTeste.Click += new System.EventHandler(this.buttonGravarTeste_Click);
            // 
            // textBoxEnunciadoTeste
            // 
            this.textBoxEnunciadoTeste.Location = new System.Drawing.Point(127, 334);
            this.textBoxEnunciadoTeste.Name = "textBoxEnunciadoTeste";
            this.textBoxEnunciadoTeste.Size = new System.Drawing.Size(224, 31);
            this.textBoxEnunciadoTeste.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 81;
            this.label9.Text = "Matéria:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 25);
            this.label10.TabIndex = 80;
            this.label10.Text = "Enunciado:";
            // 
            // txtBoxNumeroQuestoes
            // 
            this.txtBoxNumeroQuestoes.Location = new System.Drawing.Point(131, 124);
            this.txtBoxNumeroQuestoes.Name = "txtBoxNumeroQuestoes";
            this.txtBoxNumeroQuestoes.Size = new System.Drawing.Size(220, 31);
            this.txtBoxNumeroQuestoes.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 50);
            this.label11.TabIndex = 78;
            this.label11.Text = "Número \r\nde questões:";
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Items.AddRange(new object[] {
            "Historia",
            "Matematica",
            "Portugues ",
            "Filosofia"});
            this.comboBoxMateria.Location = new System.Drawing.Point(127, 274);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(224, 33);
            this.comboBoxMateria.TabIndex = 94;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(372, 334);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(112, 37);
            this.btnAdicionar.TabIndex = 95;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // checkedListBoxAlternativa
            // 
            this.checkedListBoxAlternativa.FormattingEnabled = true;
            this.checkedListBoxAlternativa.Location = new System.Drawing.Point(521, 176);
            this.checkedListBoxAlternativa.Name = "checkedListBoxAlternativa";
            this.checkedListBoxAlternativa.Size = new System.Drawing.Size(288, 312);
            this.checkedListBoxAlternativa.TabIndex = 96;
            this.checkedListBoxAlternativa.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAlternativa_SelectedIndexChanged);
            // 
            // CadastroQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 503);
            this.Controls.Add(this.checkedListBoxAlternativa);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.comboBoxMateria);
            this.Controls.Add(this.checkBoxTeste);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAlternativa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxDisciplinaTeste);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCancelarTeste);
            this.Controls.Add(this.buttonGravarTeste);
            this.Controls.Add(this.textBoxEnunciadoTeste);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxNumeroQuestoes);
            this.Controls.Add(this.label11);
            this.Name = "CadastroQuestao";
            this.Text = "CadastroQuestao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxTeste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAlternativa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDisciplinaTeste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancelarTeste;
        private System.Windows.Forms.Button buttonGravarTeste;
        private System.Windows.Forms.TextBox textBoxEnunciadoTeste;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxNumeroQuestoes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.CheckedListBox checkedListBoxAlternativa;
    }
}