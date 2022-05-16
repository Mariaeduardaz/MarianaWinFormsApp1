using MarianaWinFormsApp1.Dominio.ModuloDisciplina;
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

namespace MarianaWinFormsApp1.Apresentacao.ModuloDisciplina
{
    public partial class ListagemDisciplinaControl : UserControl
    {
        public ListagemDisciplinaControl()
        {
            InitializeComponent();
            dataGridDisciplina.ConfigurarGridZebrado();
            dataGridDisciplina.ConfigurarGridSomenteLeitura();
            dataGridDisciplina.Columns.AddRange(ObterColunas());
        }
        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"}
            };

            return colunas;
        }
        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            dataGridDisciplina.Rows.Clear();

            foreach (Disciplina disciplina in disciplinas)
            {
                dataGridDisciplina.Rows.Add(disciplina.Numero, disciplina.Nome);
            }

        }
        public int ObtemNumeroTarefaSelecionada()
        {
            return dataGridDisciplina.SelecionarNumero<int>();
        }
    }
}
