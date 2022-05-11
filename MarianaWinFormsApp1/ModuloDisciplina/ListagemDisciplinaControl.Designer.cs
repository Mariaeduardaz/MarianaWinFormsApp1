namespace MarianaWinFormsApp1.ModuloDisciplina
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.listDisciplina = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.listDisciplina);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(606, 524);
            this.tabControl1.TabIndex = 1;
            // 
            // listDisciplina
            // 
            this.listDisciplina.Location = new System.Drawing.Point(4, 34);
            this.listDisciplina.Name = "listDisciplina";
            this.listDisciplina.Padding = new System.Windows.Forms.Padding(3);
            this.listDisciplina.Size = new System.Drawing.Size(598, 486);
            this.listDisciplina.TabIndex = 1;
            this.listDisciplina.Text = "tabPage2";
            this.listDisciplina.UseVisualStyleBackColor = true;
            // 
            // ListagemDisciplinaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ListagemDisciplinaControl";
            this.Size = new System.Drawing.Size(829, 549);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage listDisciplina;
    }
}
