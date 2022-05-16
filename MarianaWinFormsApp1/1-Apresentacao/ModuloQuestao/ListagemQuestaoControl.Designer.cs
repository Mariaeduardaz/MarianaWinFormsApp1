namespace MarianaWinFormsApp1.Apresentacao.ModuloQuestao
{
    partial class ListagemQuestaoControl
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
            this.dataGridQuestao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestao)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridQuestao
            // 
            this.dataGridQuestao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuestao.Location = new System.Drawing.Point(3, 78);
            this.dataGridQuestao.Name = "dataGridQuestao";
            this.dataGridQuestao.RowHeadersWidth = 62;
            this.dataGridQuestao.RowTemplate.Height = 33;
            this.dataGridQuestao.Size = new System.Drawing.Size(608, 363);
            this.dataGridQuestao.TabIndex = 0;
            // 
            // ListagemQuestaoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridQuestao);
            this.Name = "ListagemQuestaoControl";
            this.Size = new System.Drawing.Size(616, 444);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridQuestao;
    }
}
