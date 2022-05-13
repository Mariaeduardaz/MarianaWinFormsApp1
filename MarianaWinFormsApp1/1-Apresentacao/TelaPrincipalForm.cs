using MarianaWinFormsApp1.Compartilhado;
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
        private ConfiguracaoToolBoxBase configuracaoToolBox;
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void disciplinaMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDisciplina cadastrodisciplina = new CadastroDisciplina();
            cadastrodisciplina.ShowDialog();


            ConfigurarToolbox( new ConfiguracaoToolboxDisciplina());

            ListagemDisciplinaControl listagem = new ListagemDisciplinaControl();
            
            listagem.Dock = DockStyle.Fill;

            PanelRegistros.Controls.Clear();

            PanelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolbox(ConfiguracaoToolBoxBase configuracao)
        {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;
        }

        private void MateriaMenuItem_Click(object sender, EventArgs e)
        {

            CadastroMateria cadastromateria = new CadastroMateria();
            cadastromateria.ShowDialog();

            ConfigurarToolbox(new ConfiguracaoToolBoxMateria());

            ListagemMateriaControl listagem = new ListagemMateriaControl();

            PanelRegistros.Controls.Clear();

            PanelRegistros.Controls.Add(listagem);
            
        }

        private void questãoMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroQuestao cadastroquestao = new CadastroQuestao();
            cadastroquestao.ShowDialog();

            ConfigurarToolbox(new ConfiguracaoToolBoxQuestao());

            ListagemQuestaoControl listagem = new ListagemQuestaoControl();

            PanelRegistros.Controls.Clear();

            PanelRegistros.Controls.Add(listagem);
            
        }

        private void panelRegistros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
