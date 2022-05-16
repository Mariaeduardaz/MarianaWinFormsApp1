using FluentValidation.Results;
using MarianaWinFormsApp1._2_Dominio.ModuloQuestao;
using MarianaWinFormsApp1._3_Infra.ModuloDisciplina;
using MarianaWinFormsApp1._3_Infra.ModuloMateria;
using MarianaWinFormsApp1.Dominio.ModuloDisciplina;
using MarianaWinFormsApp1.Dominio.ModuloMateria;
using MarianaWinFormsApp1.Dominio.ModuloQuestao;
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
    public partial class CadastroQuestao : Form
    {
        private Questao _questao;
        private RepositorioEmArquivoDisciplina _repositorioDisciplina;
        private RepositorioEmArquivoMateria _repositorioMateria;

        public Questao Questao
        {
            get
            {
                return _questao;
            }
            set
            {
                _questao = value;
                txtBoxNumeroQuestoes.Text = _questao.Numero.ToString();
                comboBoxDisciplinaTeste.SelectedItem = _questao.Disciplina;
                comboBoxMateria.SelectedItem = _questao.Materia;
                textBoxEnunciadoTeste.Text = _questao.Enunciado;
               
            }
        }
        public CadastroQuestao(RepositorioEmArquivoDisciplina cadastrodisciplina, RepositorioEmArquivoMateria cadastromateria)
        {
            InitializeComponent();
            this._repositorioDisciplina = cadastrodisciplina;
            this._repositorioMateria = cadastromateria;
            PovoarDisciplinas();
            comboBoxDisciplinaTeste.SelectedItem = 0;
        }
        public void PovoarDisciplinas()
        {
            List<Disciplina> disciplinas = _repositorioDisciplina.SelecionarTodos();
            foreach (var item in disciplinas)
                comboBoxDisciplinaTeste.Items.Add(item);
        }

        public CadastroQuestao()
        {
            InitializeComponent();
        }

        private void buttonGravarTeste_Click(object sender, EventArgs e)
        {

            Questao.Enunciado = textBoxEnunciadoTeste.Text.ToString();
            Questao.Disciplina = (Disciplina)comboBoxDisciplinaTeste.SelectedItem;
            Questao.Materia = (Materia)comboBoxMateria.SelectedItem;

           

            var resultadoValidacao = GravarRegistro!(Questao); // _repositorioDisciplina.Inserir();

            if (!resultadoValidacao.IsValid)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia!.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
        public Func<Questao, ValidationResult>? GravarRegistro { get; set; }
        public List<Alternativa> AlternativasAdicionadas
        {
            get
            {
                return checkedListBoxAlternativa.CheckedItems.Cast<Alternativa>().ToList();
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (textBoxAlternativa.Text != string.Empty && textBoxAlternativa.Text != "")
            {
                if (checkedListBoxAlternativa.Items.Count < 4)
                {
                    List<string> titulos = AlternativasAdicionadas.Select(x => x.Opcao).ToList();

                    if (titulos.Count == 0 || titulos.Contains(textBoxAlternativa.Text) == false)
                    {
                        Alternativa alt = new();

                        alt.Opcao = textBoxAlternativa.Text;

                        checkedListBoxAlternativa.Items.Add(alt);
                        textBoxAlternativa.Clear();
                        textBoxAlternativa.Focus();
                    }
                }
            }
        }

        private void checkedListBoxAlternativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxAlternativa.CheckedItems.Count > 0)
            {
                foreach (int i in checkedListBoxAlternativa.CheckedIndices)
                    checkedListBoxAlternativa.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
        private void comboBoxDisciplinas_SelectedValueChanged(object sender, EventArgs e)
        {
            
            comboBoxMateria.Enabled = true;
        }
    }
}
