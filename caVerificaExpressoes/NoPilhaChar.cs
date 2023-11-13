using caPilhaDinamica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVerificadorEquacoes
{
    internal class NoPilhaChar
    {
        //atributos
        public char info;
        public NoPilhaChar next;

        //metodos
        public NoPilhaChar()
        { }

        public NoPilhaChar(char _info) //aridade 1
        {
            info = _info;
            next = null;
        }
    }
}
