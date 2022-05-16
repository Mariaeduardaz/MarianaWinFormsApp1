using FluentValidation;
using FluentValidation.Results;
using MarianaWinFormsApp1._2_Dominio.ModuloDisciplina;
using MarianaWinFormsApp1._3_Infra.Compartilhado;
using MarianaWinFormsApp1.Dominio.ModuloDisciplina;
using MarianaWinFormsApp1.Infra.Compartilhado;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1._3_Infra.ModuloDisciplina
{
    public  class RepositorioEmArquivoDisciplina : RepositorioInfraEmArquivo<Disciplina>
    {
        public RepositorioEmArquivoDisciplina(DataContext contextoDados) : base(contextoDados)
        {
            if (dataContext.Disciplinas.Count > 0)
                contador = dataContext.Disciplinas.Max(x => x.Numero);
        }

        public override ValidationResult Inserir(Disciplina novoRegistro)
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
        public override ValidationResult Editar(Disciplina registro)
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

         private ValidationResult Validar(Disciplina registro)
        {
            var validator = ObterValidador();

            var resultadoValidacao = validator.Validate(registro);

            foreach (var item in dataContext.Disciplinas)
            {
                if (item.Nome == registro.Nome && item.Numero != registro.Numero)
                    resultadoValidacao.Errors.Add(new ValidationFailure("", "Nome já cadastrado"));
            }

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            return resultadoValidacao;
        }
        public override List<Disciplina> ObterRegistros()
        {
            return dataContext.Disciplinas;
        }

        public override AbstractValidator<Disciplina> ObterValidador()
        {
            return new ValidarDisciplina();
        }
    }
    
}
