using MarianaWinFormsApp1.Compartilhado;
using MarianaWinFormsApp1.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1.ModuloDisciplina
{
    public class ConfiguracaoToolboxDisciplina : ConfiguracaoToolBoxBase
    {
        public override string TooltipInserir { get { return "Inserir uma nova disciplina"; } }

        public override string TooltipEditar { get { return "Editar uma  disciplina"; } }

        public override string TooltipExcluir { get { return "Excluir uma  disciplina"; } }
    }
}
