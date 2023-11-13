using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    internal class NoPilha
    {
        //atributos
        public int info;
        public NoPilha next;

        //metodos
        public NoPilha()
        { }

        public NoPilha(int _info) //aridade 1
        {
            info = _info;
            next = null;
        }
    }
}
