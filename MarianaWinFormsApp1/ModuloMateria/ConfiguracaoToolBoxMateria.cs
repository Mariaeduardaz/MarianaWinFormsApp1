using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1.ModuloMateria
{
    public class ConfiguracaoToolBoxMateria : ConfiguracaoToolBoxBase
    {
        public override string TooltipInserir { get { return "Inserir uma nova materia"; } }

        public override string TooltipEditar { get { return "Editar uma  materia"; } }

        public override string TooltipExcluir { get { return "Excluir uma  materia"; } }
    }
}
