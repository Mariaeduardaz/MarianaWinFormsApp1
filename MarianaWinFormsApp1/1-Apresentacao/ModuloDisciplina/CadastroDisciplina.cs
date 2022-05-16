using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using MarianaWinFormsApp1.Dominio.ModuloDisciplina;

namespace MarianaWinFormsApp1.Apresentacao.ModuloDisciplina
{
    public partial class CadastroDisciplina : Form
    {
        private Disciplina? _disciplina;

        public CadastroDisciplina()
        {
        }

        public CadastroDisciplina(Disciplina disciplina)
        {
            InitializeComponent();

            
                
            
        }
        public Func<Disciplina, ValidationResult>? GravarRegistro { get; set; }
        public Disciplina Disciplina
        {

            get
            {
                return _disciplina!;
            }
            set
            {
                _disciplina = value;
                txtNomeDisciplina.Text = _disciplina.Nome;


            }

        }

        

        public void btnGravar_Click(object sender, EventArgs e)
        {
            _disciplina!.Nome = txtNomeDisciplina.Text;

            var resultadoValidacao = GravarRegistro!(Disciplina);

            if(resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;
                

                DialogResult = DialogResult.OK;
            }
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
