using FluentValidation;
using MarianaWinFormsApp1.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1._2_Dominio.ModuloDisciplina
{
    public class ValidarDisciplina : AbstractValidator<Disciplina>
    {
        public ValidarDisciplina()
        {
            RuleFor(x => x.Nome)
               .NotNull()
               .NotEmpty();
        }
    }
}
