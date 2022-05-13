using MarianaWinFormsApp1.Dominio.Compartilhado;
using MarianaWinFormsApp1.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1.Dominio.ModuloDisciplina
{
    public interface IRepositorioDisciplina : IRepositorioBase<Disciplina>
    {
        List<Questao> SelecionarQuestoes();

        Disciplina SelecionarPorNumero(object numero);



    }
}
