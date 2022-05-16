﻿using FluentValidation;
using FluentValidation.Results;
using MarianaWinFormsApp1.Dominio.Compartilhado;
using MarianaWinFormsApp1.Infra.Compartilhado;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1._3_Infra.Compartilhado
{
    public abstract class RepositorioInfraEmArquivo<T> where T : EntidadeBase<T>
    {
        protected DataContext dataContext;
        protected int contador = 0;

        public RepositorioInfraEmArquivo(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public virtual T SelecionarPorNumero(int numero)
        {
            return ObterRegistros()
                .FirstOrDefault(x => x.Numero == numero);
        }

        public virtual ValidationResult Inserir(T novoRegistro)
        {
            var validator = ObterValidador();

            var resultadoValidacao = validator.Validate(novoRegistro);

            if (resultadoValidacao.IsValid)
            {
                novoRegistro.Numero = ++contador;

                var registros = ObterRegistros();

                registros.Add(novoRegistro);
            }

            return resultadoValidacao;
        }

        public virtual ValidationResult Editar(T registro)
        {
            var validator = ObterValidador();

            var resultadoValidacao = validator.Validate(registro);

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

        public virtual ValidationResult Excluir(T registro)
        {
            var resultadoValidacao = new ValidationResult();

            var registros = ObterRegistros();

            if (!registros.Remove(registro))
                resultadoValidacao.Errors.Add(new ValidationFailure("", "Não é possível remover o registro"));

            return resultadoValidacao;
        }
       
        public virtual List<T> SelecionarTodos()
        {
            return ObterRegistros();
        }
       


        public abstract List<T> ObterRegistros();

        public abstract AbstractValidator<T> ObterValidador();
    }
}
