using MarianaWinFormsApp1.Dominio.ModuloDisciplina;
using MarianaWinFormsApp1.Dominio.ModuloMateria;
using MarianaWinFormsApp1.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1.Infra.Compartilhado
{
    public class DataContext
    {
        private readonly ISerializador serializador;

        public DataContext()
        {
            Disciplinas = new List<Disciplina>();
            Materias = new List<Materia>();
            Questoes = new List<Questao>();
        }
        public DataContext(ISerializador serializador) : this()
        {
            this.serializador = serializador;

            CarregarDados();


        }
        public List<Disciplina> Disciplinas { get; set; }

        public List<Materia> Materias { get; set; }

        public List<Questao> Questoes { get; set; }

        private void CarregarDados()
        {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Disciplinas.Any())
                this.Disciplinas.AddRange(ctx.Disciplinas);

            if (ctx.Materias.Any())
                this.Materias.AddRange(ctx.Materias);

            if (ctx.Questoes.Any())
                this.Questoes.AddRange(ctx.Questoes);

        }
        public void GravarDados()
        {
            serializador.GravarDadosEmArquivo(this);
        }

    }
}
