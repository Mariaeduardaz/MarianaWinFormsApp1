namespace MarianaWinFormsApp1.Apresentacao.ModuloMateria
{
    partial class ListagemMateriaControl
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
            this.dataGridMateria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMateria
            // 
            this.dataGridMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMateria.Location = new System.Drawing.Point(3, 61);
            this.dataGridMateria.Name = "dataGridMateria";
            this.dataGridMateria.RowHeadersWidth = 62;
            this.dataGridMateria.RowTemplate.Height = 33;
            this.dataGridMateria.Size = new System.Drawing.Size(665, 395);
            this.dataGridMateria.TabIndex = 0;
            // 
            // FormularioMateriaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridMateria);
            this.Name = "FormularioMateriaControl";
            this.Size = new System.Drawing.Size(671, 459);
            this.Load += new System.EventHandler(this.FormularioMateriaControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMateria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridMateria;
    }
}
