using MarianaWinFormsApp1.ModuloMateria;

namespace MarianaWinFormsApp1.ModuloDisciplina
{
    public class ConfiguracaoToolboxDisciplina : ConfiguracaoToolBoxBase
    {
        public override string TooltipInserir { get { return "Inserir uma nova disciplina"; } }

        public override string TooltipEditar { get { return "Editar uma  disciplina"; } }

        public override string TooltipExcluir { get { return "Excluir uma  disciplina"; } }
    }
}