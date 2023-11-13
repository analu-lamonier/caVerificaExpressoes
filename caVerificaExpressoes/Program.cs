using caPilhaDinamica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace caVerificaExpressoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int correspondentes(int abertura, char fechamento)
            {
                if (abertura == '[' & fechamento == ']') 
                    return 1;
                else if (abertura == '(' & fechamento == ')')
                    return 1;
                else if (abertura == '{' & fechamento == '}') 
                    return 1;

                else return 0;
            }

            int verificador (string exp)
            {

                Pilha pilha = new Pilha();

                for (int i = 0; i < exp.Length; i++)
                {
                    if (exp[i] == '[' | exp[i] == '(' | exp[i] == '{')
                    {
                        pilha.Insere(exp[i]);
                    }
                    else if (exp[i] == ']' | exp[i] == ')' | exp[i] == '}')
                    {   
                        if (pilha.EstaVazia())
                        {
                            Console.WriteLine("Expresão errada!");
                            return 0;
                        }
                        int removido = pilha.Remove();
                        if (correspondentes(removido, exp[i]) == 0)
                        {
                            Console.WriteLine("Expresão errada!");
                            return 0;
                        }
                        
                    }
                }
                

                if (pilha.EstaVazia())
                {
                    Console.WriteLine("Expresão correta!");
                    return 0;
                }

                Console.WriteLine("Expresão Errada!");
                return 0;
            }


            Console.WriteLine("Insira a expressão: ");
            string expressao = Console.ReadLine();


            Console.WriteLine(verificador(expressao));
            Console.ReadLine();


        }
    }
}
