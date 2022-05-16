using FluentValidation.Results;
using MarianaWinFormsApp1.Dominio.ModuloDisciplina;
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
    public partial class CadastroMateria : Form
    {
        private Materia? _materia;
        public List<Disciplina> Disciplinas { get; set; }
        public CadastroMateria(Materia materia)
        {
            InitializeComponent();

           
        }
        public Materia Materia
        {
            get
            {
                return _materia!;
            }
            set
            {
                _materia = value;
                txtNumeroMateria.Text = _materia.Numero.ToString();
                txtNomeMateria.Text = _materia.Nome;
                comboBoxSerieMateria.SelectedItem = _materia.Serie;
                comboBoxDisciplinaMateria.SelectedItem = _materia.Disciplina;
            }
        }

        public CadastroMateria()
        {
            InitializeComponent();
        }
        public CadastroMateria(List<Disciplina> disciplinas)
        {
            InitializeComponent();
            this.Disciplinas = disciplinas;
            CarregarDisciplinas();
            comboBoxSerieMateria.SelectedIndex = 0;
        }
        private void CarregarDisciplinas()
        {
            foreach (var disciplina in Disciplinas)
            {
                comboBoxDisciplinaMateria.Items.Add(disciplina);
            }
        }


        private void comboBoxSerieMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public Func<Materia, ValidationResult>? GravarRegistro { get; set; }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            _materia!.Nome = txtNumeroMateria.Text;
            
            _materia!.Serie = comboBoxSerieMateria.Text;
            Materia.Disciplina = (Disciplina)comboBoxDisciplinaMateria.SelectedItem;

            var resultadoValidacao = GravarRegistro!(Materia);
            
            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia!.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
