using caPilhaDinamica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVerificadorEquacoes
{
    internal class PilhaChar
    {
        //atributos

        NoPilhaChar topo;

        //metodos

        public PilhaChar()
        {
            topo = null;

        }

        public void Insere(char n)
        {
            NoPilhaChar novoNo = new NoPilhaChar(n);
            novoNo.next = topo; // fazendo o encadeamento
            topo = novoNo; // topo aponta para o nó criado
        }

        public void Imprime()
        {
            NoPilhaChar temp = topo;
            while (temp != null)
            {
                Console.WriteLine(temp.info);
                temp = temp.next;
            }

        }

        public char Remove()
        {
            char temp = topo.info;
            topo = topo.next;
            return temp;
        }
    }
}
