using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1
{
    public class Materia_1 : EntidadeBase
    {

        private string numero;
        private string nome;
        private string disciplina;
        private string serie;

        public string Numero { get { return numero; } set { numero = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Disciplina { get { return disciplina; } set { disciplina = value; } }
        public string Serie { get; set; }

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
