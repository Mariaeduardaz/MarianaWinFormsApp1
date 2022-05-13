using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarianaWinFormsApp1.ModuloMateria
{
    public partial class CadastroMateria : Form
    {
        private Materia_1? _materia;
        public CadastroMateria(Materia_1 materia)
        {
            InitializeComponent();

            _materia = materia;
            if (materia != null)
            {
                txtNumeroMateria.Text = materia.Numero;
                txtNomeMateria.Text = materia.Nome;
                comboBoxDisciplinaMateria.Text = materia.Disciplina;
                comboBoxSerieMateria.Text = materia.Serie;
                
                
            }
        }

        public CadastroMateria()
        {
            InitializeComponent();
        }

        private void comboBoxSerieMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            _materia!.Nome = txtNumeroMateria.Text;
            _materia!.Numero = txtNomeMateria.Text;
            _materia!.Serie = comboBoxSerieMateria.Text;
             _materia.Disciplina = comboBoxDisciplinaMateria.Text;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
