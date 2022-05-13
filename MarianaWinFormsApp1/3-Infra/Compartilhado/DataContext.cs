using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1.Infra.Compartilhado
{
    public class DataContext
    {
        private readonly ISerializador serializador;

        
        
            Disciplina = new List<Disciplina>();

            Contatos = new List<Contato>();

            Compromissos = new List<Compromisso>();

            Despesas = new List<Despesa>();
        
            
        public List<Tarefa> Disciplina { get; set; }

        public List<Contato> Contatos { get; set; }

        public List<Compromisso> Compromissos { get; set; }
    }

}
