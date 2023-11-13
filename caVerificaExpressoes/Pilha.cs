using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    internal class Pilha
    {
        //atributos

        NoPilha topo;

        //metodos

        public Pilha()
        {
            topo = null;

        }

        public void Insere(int n)
        {
            NoPilha novoNo = new NoPilha(n);
            novoNo.next = topo; // fazendo o encadeamento
            topo = novoNo; // topo aponta para o nó criado
        }

        public void Imprime()
        {
            NoPilha temp = topo;
            while (temp != null) 
            {
                Console.WriteLine(temp.info);
                temp = temp.next;
            }

        }

        public bool EstaVazia()
        {
            NoPilha temp = topo;
            if (temp == null) 
                return true;
            else
                return false;
        }
        public int Remove()
        {
            int temp = topo.info;
            topo = topo.next;
            return temp;
        }


    }
}
