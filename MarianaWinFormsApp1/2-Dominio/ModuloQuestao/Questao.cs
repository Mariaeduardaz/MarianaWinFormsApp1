using MarianaWinFormsApp1.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        private string numeroDeQuestões;
        private string disciplina;
        private string materia;
        private string enunciado;
        private string resposta;

        public Questao()
        {

        }

        public string NumeroDeQuestões { get { return numeroDeQuestões; } set { numeroDeQuestões = value; } }
        public string Disciplina { get { return disciplina; } set { disciplina = value; } }
        public string Materia { get { return materia; } set { materia = value; } }
        public string Enunciado { get { return enunciado; } set { enunciado = value; } }
        public string Resposta { get { return resposta; } set { resposta = value; } }

        public override string ToString()
        {

            return $"NumeroDeQuestões: {NumeroDeQuestões} Disciplina: {Disciplina} Materia: {Materia} Enunciado: {Enunciado} Resposta: {Resposta} ";
        }
        public override string Validar()
        {
            StringBuilder sb = new();
            return sb.ToString().Trim();
        }
    }
}
