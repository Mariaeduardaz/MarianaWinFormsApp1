using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarianaWinFormsApp1
{
    public partial class CadastroDisciplina : Form
    {
        private Disciplina_1? _disciplina;

        public CadastroDisciplina()
        {
            InitializeComponent();
        }

        public CadastroDisciplina(Disciplina_1 disciplina)
        {
            InitializeComponent();

            _disciplina = disciplina;
                if (disciplina != null)
                {
                    txtNomeDisciplina.Text = disciplina.Nome;
                  
                }
            
        }
        public Disciplina_1 disciplina
        {
            get { return _disciplina; }
            set { _disciplina = value; }
        }


        public void btnGravar_Click(object sender, EventArgs e)
        {
            _disciplina!.Nome = txtNomeDisciplina.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroDisciplina_Load(object sender, EventArgs e)
        {

        }
    }
}
