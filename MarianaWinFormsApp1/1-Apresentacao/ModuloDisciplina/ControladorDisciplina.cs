using MarianaWinFormsApp1._1_Apresentacao.Compartilhado;
using MarianaWinFormsApp1._3_Infra.ModuloDisciplina;
using MarianaWinFormsApp1._3_Infra.ModuloMateria;
using MarianaWinFormsApp1.Apresentacao.ModuloDisciplina;
using MarianaWinFormsApp1.Dominio.ModuloDisciplina;
using MarianaWinFormsApp1.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarianaWinFormsApp1._1_Apresentacao.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private RepositorioEmArquivoDisciplina _repositorioDisciplina;
        private RepositorioEmArquivoMateria _repositorioMateria;

        private ListagemDisciplinaControl? tabelaDisciplinas;

        public ControladorDisciplina(RepositorioEmArquivoDisciplina repositorioDisciplina, RepositorioEmArquivoMateria repositorioMateria)
        {
            this._repositorioDisciplina = repositorioDisciplina;
            this._repositorioMateria = repositorioMateria;
        }

        public override void Editar()
        {
            CadastroDisciplina tela = new();

            Disciplina disciplinaSelecionada = ObtemDisciplinaSelecionada();

            if (disciplinaSelecionada == null)
            {
                TelaPrincipalForm.Instancia!.AtualizarRodape("Seleciona uma disciplina!");
                return;
            }

            tela.Disciplina = disciplinaSelecionada.Clone();

            tela.GravarRegistro = _repositorioDisciplina.Editar;

            DialogResult res = tela.ShowDialog(); 

            if (res == DialogResult.OK)
                CarregarDisciplinas();
        }

        public override void Excluir()
        {
            Disciplina disciplinaSelecionada = ObtemDisciplinaSelecionada();

            if (disciplinaSelecionada == null)
            {
                TelaPrincipalForm.Instancia!.AtualizarRodape("Seleciona uma disciplina!");
                return;
            }
            List<Materia> materias = _repositorioMateria.ObterRegistros();
            foreach (var item in materias)
            {
                if (item.Disciplina == disciplinaSelecionada)
                {
                    TelaPrincipalForm.Instancia!.AtualizarRodape("Esta disciplina não pode ser excluída pois está atrelada a alguma matéria");
                    return;
                }
            }
        }
        private Disciplina ObtemDisciplinaSelecionada()
        {
            var numero = tabelaDisciplinas!.ObtemNumeroTarefaSelecionada();
            return _repositorioDisciplina.SelecionarPorNumero(numero);
        }
        public override void Inserir()
        {
            CadastroDisciplina tela = new();
            tela.Disciplina = new();

            tela.GravarRegistro = _repositorioDisciplina.Inserir;

            DialogResult res = tela.ShowDialog(); // Daqui vai para os códigos da 'TelaCadastroDisciplinaForm'

            if (res == DialogResult.OK)
                CarregarDisciplinas();
        }
       
        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = _repositorioDisciplina.SelecionarTodos();
            tabelaDisciplinas!.AtualizarRegistros(disciplinas);

            TelaPrincipalForm.Instancia!.AtualizarRodape($"Visualizando {disciplinas.Count} disciplina(s)");
        }

        public override UserControl ObtemListagem()
        {
            throw new NotImplementedException();
        }
    }
}
