using MarianaWinFormsApp1.Dominio.ModuloMateria;
using MarianaWinFormsApp1.WinApp.Compartilhado;
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
    public partial class ListagemMateriaControl : UserControl
    {
        private Materia materia;
        public ListagemMateriaControl()
        {
            InitializeComponent();
        }

        private void FormularioMateriaControl_Load(object sender, EventArgs e)
        {
            this.materia = new Materia();

        }
        public int ObtemNumeroMateriaSelecionada()
        {
            return dataGridMateria.SelecionarNumero<int>();
        }
        public void AtualizarRegistros(List<Materia> materias)
        {
            dataGridMateria.Rows.Clear();

            foreach (Materia materia in materias)
            {
                dataGridMateria.Rows.Add(materia.Numero, materia.Nome, materia.Disciplina, materia.Serie);
            }

        }
    }
}
