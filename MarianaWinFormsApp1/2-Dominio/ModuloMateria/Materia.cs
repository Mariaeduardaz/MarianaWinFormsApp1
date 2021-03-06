using MarianaWinFormsApp1.Dominio.Compartilhado;
using MarianaWinFormsApp1.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MarianaWinFormsApp1.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {

        private int numero;
        private string nome;
        private string disciplina;
        private string serie;

        public int Numero { get { return numero; } set { numero = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public Disciplina Disciplina { get; set; }
        public string Serie { get { return serie; } set { serie = value; } }

        public override void Atualizar(Materia registro)
        {
            this.Nome = registro.Nome;
            this.Serie = registro.Serie;
            this.Disciplina = registro.Disciplina;
        }
        public Materia Clone()
        {
            return new Materia
            {
                Numero = this.Numero,
                Disciplina = this.Disciplina,
                Nome = this.Nome,
                Serie = this.Serie
               
            };
        }
        public override string ToString()
        {

            return $"Numero: {Numero} Nome: {Nome} numero: {Disciplina} disciplina: {Serie} serie: ";
        }
        public override string Validar()
        {
            StringBuilder sb = new();
            return sb.ToString().Trim();
        }
    }
}
