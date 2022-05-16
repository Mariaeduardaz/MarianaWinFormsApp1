using MarianaWinFormsApp1._2_Dominio.ModuloQuestao;
using MarianaWinFormsApp1.Dominio.ModuloQuestao;
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

namespace MarianaWinFormsApp1.Apresentacao.ModuloQuestao
{
    public partial class ListagemQuestaoControl : UserControl
    {
        public ListagemQuestaoControl()
        {
            InitializeComponent();
            dataGridQuestao.ConfigurarGridZebrado();
            dataGridQuestao.ConfigurarGridSomenteLeitura();
            dataGridQuestao.Columns.AddRange(ObterColunas());
        }
        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Matéria"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Número", HeaderText = "Número"}
            };

            return colunas;
        }
        public void AtualizarRegistros(List<Questao> questoes)
        {
            dataGridQuestao.Rows.Clear();

            foreach (Questao questao in questoes)
            {
                dataGridQuestao.Rows.Add(questao.Numero, questao.Enunciado, questao.Disciplina, questao.Materia);
            }

        }
       
        public int ObtemNumeroMateriaSelecionada()
        {
            return dataGridQuestao.SelecionarNumero<int>();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
