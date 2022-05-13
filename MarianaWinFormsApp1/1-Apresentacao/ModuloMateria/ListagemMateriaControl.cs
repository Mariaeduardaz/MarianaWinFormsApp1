using MarianaWinFormsApp1.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarianaWinFormsApp1.Apresentacao.ModuloMateria
{
    public partial class FormularioMateriaControl : UserControl
    {
        private Materia materia;
        public FormularioMateriaControl()
        {
            InitializeComponent();
        }

        private void FormularioMateriaControl_Load(object sender, EventArgs e)
        {
            this.materia = new Materia();

        }
    }
}
