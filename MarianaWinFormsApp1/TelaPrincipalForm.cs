using MarianaWinFormsApp1.ModuloDisciplina;
using MarianaWinFormsApp1.ModuloMateria;
using MarianaWinFormsApp1.ModuloQuestao;
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
    public partial class TelaPrincipalForm : Form
    {
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void disciplinaMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoToolboxDisciplina configuracao = new ConfiguracaoToolboxDisciplina();

            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText= configuracao.TooltipExcluir;

            ListagemDisciplinaControl listagem = new ListagemDisciplinaControl();

            listagem.Dock = DockStyle.Fill;
                       
            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void MateriaMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoToolBoxMateria configuracao = new ConfiguracaoToolBoxMateria();

            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;

            ListagemMateriaControl listagem = new ListagemMateriaControl();

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void questãoMenuItem1_Click(object sender, EventArgs e)
        {
            ConfiguracaoToolBoxQuestao configuracao = new ConfiguracaoToolBoxQuestao();

            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;

            ListagemQuestaoControl listagem = new ListagemQuestaoControl();

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void panelRegistros_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
