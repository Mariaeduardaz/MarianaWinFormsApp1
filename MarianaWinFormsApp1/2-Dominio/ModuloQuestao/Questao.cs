using MarianaWinFormsApp1._2_Dominio.ModuloQuestao;
using MarianaWinFormsApp1.Dominio.Compartilhado;
using MarianaWinFormsApp1.Dominio.ModuloDisciplina;
using MarianaWinFormsApp1.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public string Enunciado { get; set; }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public List<Alternativa> Alternativa { get; set; }

        public override void Atualizar(Questao registro)
        {
            this.Enunciado = registro.Enunciado;
            this.Disciplina = registro.Disciplina;
            this.Materia = registro.Materia;
            this.Alternativa = registro.Alternativa;
        }


        public Questao Clone()
        {
            return new Questao
            {
                Numero = this.Numero,
                Enunciado = this.Enunciado,
                Disciplina = this.Disciplina,
                Materia = this.Materia,
                Alternativa = this.Alternativa
            };
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
