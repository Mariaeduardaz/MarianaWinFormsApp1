using FluentValidation;
using FluentValidation.Results;
using MarianaWinFormsApp1._2_Dominio.ModuloQuestao;
using MarianaWinFormsApp1._3_Infra.Compartilhado;
using MarianaWinFormsApp1.Dominio.ModuloQuestao;
using MarianaWinFormsApp1.Infra.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1._3_Infra.ModuloQuestao
{
    public class RepositorioEmArquivoQuestao : RepositorioInfraEmArquivo<Questao>
    
    {
        public RepositorioEmArquivoQuestao(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Questoes.Count > 0)
                contador = dataContext.Questoes.Max(x => x.Numero);
        }
        public override ValidationResult Inserir(Questao novoRegistro)
        {
            ValidationResult resultadoValidacao = Validar(novoRegistro);

            if (resultadoValidacao.IsValid)
            {
                novoRegistro.Numero = ++contador;

                var registros = ObterRegistros();

                registros.Add(novoRegistro);
            }

            return resultadoValidacao;
        }
        public override ValidationResult Editar(Questao registro)
        {
            var resultadoValidacao = Validar(registro);

            if (resultadoValidacao.IsValid)
            {
                var registros = ObterRegistros();

                foreach (var item in registros)
                {
                    if (item.Numero == registro.Numero)
                    {
                        item.Atualizar(registro);
                        break;
                    }
                }
            }

            return resultadoValidacao;
        }
        private ValidationResult Validar(Questao registro)
        {
            var validator = ObterValidador();

            var resultadoValidacao = validator.Validate(registro);

            foreach (var item in dataContext.Questoes)
            {
                if (item.Enunciado == registro.Enunciado && item.Numero != registro.Numero)
                    resultadoValidacao.Errors.Add(new ValidationFailure("", "Nome já esta cadastrado"));
            }

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            return resultadoValidacao;
        }
        public override List<Questao> ObterRegistros()
        {
            return dataContext.Questoes;
        }

        public override AbstractValidator<Questao> ObterValidador()
        {
            return new ValidadorQuestao();
        }

       
    }
}
