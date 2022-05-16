using FluentValidation.Results;
using MarianaWinFormsApp1._1_Apresentacao.Compartilhado;
using MarianaWinFormsApp1._3_Infra.ModuloDisciplina;
using MarianaWinFormsApp1._3_Infra.ModuloMateria;
using MarianaWinFormsApp1._3_Infra.ModuloQuestao;
using MarianaWinFormsApp1.Apresentacao.ModuloQuestao;
using MarianaWinFormsApp1.Dominio.ModuloDisciplina;
using MarianaWinFormsApp1.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarianaWinFormsApp1._1_Apresentacao.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private RepositorioEmArquivoQuestao _repositorioQuestao;
        private RepositorioEmArquivoMateria _repositorioMateria;
        private RepositorioEmArquivoDisciplina _repositorioDisciplina;

        private ListagemQuestaoControl _tabelaQuestao;

        public ControladorQuestao(RepositorioEmArquivoQuestao repositorioQuestao, RepositorioEmArquivoMateria repositorioMateria, RepositorioDisciplinaEmArquivo repositorioDisciplina)
        {
            this._repositorioQuestao = repositorioQuestao;
            this._repositorioMateria = repositorioMateria;
            this._repositorioDisciplina = repositorioDisciplina;
        }
        public override void Editar()
        {
            List<Disciplina> disciplinas = _repositorioDisciplina.ObterRegistros();
            CadastroQuestao tela = new(_repositorioDisciplina, _repositorioMateria);

            Questao questaoSelecionada = ObtemQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                TelaPrincipalForm.Instancia!.AtualizarRodape("Selecione uma questão!");
                return;
            }
            tela.Questao = questaoSelecionada.Clone();

            tela.GravarRegistro = _repositorioQuestao.Editar;

            DialogResult res = tela.ShowDialog(); // Daqui vai para os códigos da 'TelaCadastroDisciplinaForm'

            if (res == DialogResult.OK)
                CarregarQuestoes();
        }

        public override void Excluir()
        {
            Questao questaoSelecionada = ObtemQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                TelaPrincipalForm.Instancia!.AtualizarRodape("Selecione uma questão!");
                return;
            }

            DialogResult res = MessageBox.Show("Excluir questão?",
                "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.OK)
            {
                ValidationResult deuCerto = _repositorioQuestao.Excluir(questaoSelecionada);
                if (deuCerto.IsValid)
                    CarregarQuestoes();
            }
        }

        public override void Inserir()
        {
            CadastroQuestao tela = new(_repositorioDisciplina, _repositorioMateria);

            tela.Questao = new Questao();
            tela.GravarRegistro = _repositorioQuestao.Inserir;

            DialogResult res = tela.ShowDialog(); 

            if (res == DialogResult.OK)
                CarregarQuestoes();
        }

        public override UserControl ObtemListagem()
        {
            throw new NotImplementedException();
        }

        private void CarregarQuestoes()
        {
            List<Questao> questoes = _repositorioQuestao.SelecionarTodos();
            _tabelaQuestao!.AtualizarRegistros(questoes);

            TelaPrincipalForm.Instancia!.AtualizarRodape($"Visualizando {questoes.Count} questão(ões)");
        }

        private Questao ObtemQuestaoSelecionada()
        {
            var numero = _tabelaQuestao!.ObtemNumeroMateriaSelecionada();
            return _repositorioQuestao.SelecionarPorNumero(numero);
        }
    }
}
