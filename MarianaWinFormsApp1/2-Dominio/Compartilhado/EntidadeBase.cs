using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1.Dominio.Compartilhado
{
    public abstract class EntidadeBase<T>
    {

        public int id;
        public abstract string Validar();

    }
}
