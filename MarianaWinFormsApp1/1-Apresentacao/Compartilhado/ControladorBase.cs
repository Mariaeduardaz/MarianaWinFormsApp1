using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarianaWinFormsApp1._1_Apresentacao.Compartilhado
{
    public abstract class ControladorBase
    {
       
            public abstract void Inserir();
            public abstract void Editar();
            public abstract void Excluir();
            public virtual void Filtrar() { }
            public virtual void Agrupar() { }
            public abstract UserControl ObtemListagem();
           
        
    }
}
