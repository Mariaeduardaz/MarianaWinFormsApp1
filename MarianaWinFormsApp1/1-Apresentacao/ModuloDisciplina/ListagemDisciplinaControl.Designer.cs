namespace MarianaWinFormsApp1.Apresentacao.ModuloDisciplina
{
    partial class ListagemDisciplinaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridDisciplina = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDisciplina
            // 
            this.dataGridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisciplina.Location = new System.Drawing.Point(27, 57);
            this.dataGridDisciplina.Name = "dataGridDisciplina";
            this.dataGridDisciplina.RowHeadersWidth = 62;
            this.dataGridDisciplina.RowTemplate.Height = 33;
            this.dataGridDisciplina.Size = new System.Drawing.Size(660, 414);
            this.dataGridDisciplina.TabIndex = 5;
            // 
            // ListagemDisciplinaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridDisciplina);
            this.Name = "ListagemDisciplinaControl";
            this.Size = new System.Drawing.Size(711, 486);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisciplina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage listDisciplina;
        private System.Windows.Forms.DataGridView dataGridDisciplina;
    }
}
