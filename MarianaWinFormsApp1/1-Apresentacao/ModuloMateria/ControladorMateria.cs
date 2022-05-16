using MarianaWinFormsApp1._1_Apresentacao.Compartilhado;
using MarianaWinFormsApp1._3_Infra.ModuloDisciplina;
using MarianaWinFormsApp1._3_Infra.ModuloMateria;
using MarianaWinFormsApp1.Apresentacao.ModuloMateria;
using MarianaWinFormsApp1.Dominio.ModuloDisciplina;
using MarianaWinFormsApp1.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarianaWinFormsApp1._1_Apresentacao.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private RepositorioEmArquivoMateria _repositorioMateria;
        private RepositorioEmArquivoDisciplina _repositorioDisciplina;
        private ListagemMateriaControl tabelaMateria;

        public ControladorMateria(RepositorioEmArquivoMateria repositorioMateria, RepositorioEmArquivoDisciplina repositorioDisciplina)
        {
            this._repositorioMateria = repositorioMateria;
            this._repositorioDisciplina = repositorioDisciplina;
        }

        public override void Editar()
        {

            List<Disciplina> disciplinas = _repositorioDisciplina.ObterRegistros();
            CadastroMateria tela = new(disciplinas);

            Materia materiaSelecionada = ObtemMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                TelaPrincipalForm.Instancia!.AtualizarRodape("Selecione uma matéria!");
                return;
            }
            tela.Materia = materiaSelecionada.Clone();

            tela.GravarRegistro = _repositorioMateria.Editar;

            DialogResult res = tela.ShowDialog();
            if (res == DialogResult.OK)
                CarregarMaterias();
        }

        private Materia ObtemMateriaSelecionada()
        {
            var numero = tabelaMateria!.ObtemNumeroMateriaSelecionada();
            return _repositorioMateria.SelecionarPorNumero(numero);
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            List<Disciplina> disciplinas = _repositorioDisciplina.ObterRegistros();
            CadastroMateria tela = new(disciplinas);

            tela.Materia = new();
            tela.GravarRegistro = _repositorioMateria.Inserir;

            DialogResult res = tela.ShowDialog(); 

            if (res == DialogResult.OK)
                CarregarMaterias();
        }
        private void CarregarMaterias()
        {
            List<Materia> materias = _repositorioMateria.SelecionarTodos();
            tabelaMateria!.AtualizarRegistros(materias);

            TelaPrincipalForm.Instancia!.AtualizarRodape($"Visualizando {materias.Count} materia(s)");
        }

        public override UserControl ObtemListagem()
        {
            throw new NotImplementedException();
        }
    }
}
