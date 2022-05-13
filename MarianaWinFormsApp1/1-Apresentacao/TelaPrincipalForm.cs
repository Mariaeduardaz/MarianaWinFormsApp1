using MarianaWinFormsApp1._1_Apresentacao.Compartilhado;
using MarianaWinFormsApp1.Apresentacao.ModuloDisciplina;
using MarianaWinFormsApp1.Apresentacao.ModuloMateria;
using MarianaWinFormsApp1.Apresentacao.ModuloQuestao;
using MarianaWinFormsApp1.Compartilhado;
using MarianaWinFormsApp1.Dominio.ModuloDisciplina;
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
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        private DataContext contextoDados;

        public TelaPrincipalForm()
        {
            InitializeComponent();
            Instancia = this;

            labelRodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;

            this.contextoDados = contextoDados;

            InicializarControladores();
        }
        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }

        private void disciplinaMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDisciplina cadastrodisciplina = GetCadastrodisciplina();
            cadastrodisciplina.ShowDialog();


            ConfigurarToolbox(new ConfiguracaoToolboxDisciplina());

            ListagemDisciplinaControl listagem = new ListagemDisciplinaControl();

            listagem.Dock = DockStyle.Fill;

            PanelRegistros.Controls.Clear();

            PanelRegistros.Controls.Add(listagem);
        }
      

        private static CadastroDisciplina GetCadastrodisciplina()
        {
            return new CadastroDisciplina(new Disciplina() );
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

            FormularioMateriaControl listagem = new FormularioMateriaControl();

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

        private void PanelRegistros_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }
    }
}
