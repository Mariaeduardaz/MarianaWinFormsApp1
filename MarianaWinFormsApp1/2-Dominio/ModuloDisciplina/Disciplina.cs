using MarianaWinFormsApp1.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        private string nome;
        public string Nome { get { return nome; } set { nome = value; } }

        public override string ToString()
        {

            return $"ID: {id} Nome: {Nome}";
        }

        public override string Validar()
        {
            StringBuilder sb = new();

            if (string.IsNullOrEmpty(Nome))
                sb.AppendLine("Campo Nome é obrigatorio");
            return sb.ToString().Trim();
        }

    }


}
