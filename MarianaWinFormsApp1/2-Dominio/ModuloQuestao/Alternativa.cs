using MarianaWinFormsApp1.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1._2_Dominio.ModuloQuestao
{
    public class Alternativa : EntidadeBase<Alternativa>
    {
        public string Opcao { get; set; }
        public bool EstaCerta { get; set; }

        public override void Atualizar(Alternativa registro)
        {
            this.Opcao = registro.Opcao;
            this.EstaCerta = registro.EstaCerta;
        }

        public override string ToString()
        {
            return Opcao;
        }
    }
}
