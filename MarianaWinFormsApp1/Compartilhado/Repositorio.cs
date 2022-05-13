using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaWinFormsApp1
{
    
    
        public class Repositorio<T> where T : EntidadeBase
        {
            protected readonly List<T> registros;
            protected int contID;

            public Repositorio()
            {
                registros = new List<T>();
            }

            public string Inserir(T registro)
            {
                string resultado = registro.Validar();
                if (resultado.Trim() != "REGISTRO_VALIDO")
                    return resultado;

                registro.id = ++contID;
                registros.Add(registro);
                return "REGISTRO_VALIDO";
            }

            public string Editar(T novoRegistro, T antigoRegistro)
            {
                string resultado = novoRegistro.Validar();
                if (resultado != "REGISTRO_VALIDO")
                    return resultado;

                int posicaoEditada = registros.FindIndex(posicaoSelecionada => posicaoSelecionada.id == antigoRegistro.id);
                registros[posicaoEditada] = novoRegistro;
                return "REGISTRO_VALIDO";
            }

            public bool Excluir(T registro)
            {
                return registros.Remove(registro);
            }

            public List<T> SelecionarTodos()
            {
                return registros;
            }
        }
}
