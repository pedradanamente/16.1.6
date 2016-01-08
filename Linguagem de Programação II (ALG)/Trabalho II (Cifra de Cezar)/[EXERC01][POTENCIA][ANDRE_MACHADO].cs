using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /* TRABALHO II DE ALGORITMOS II, 17/09/2014
    /* --------------------------------------------------------------------------------------------------- *
    Potencia quando expoente é 0 então resultado é 1
    * ---------------------------------------------------------------------------------------------------- */
    class Program
    {
        static void Main(string[] args) {
            double b, e, r;
            Console.Write("Digite o valor da base: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do expoente: ");
            e = Convert.ToDouble(Console.ReadLine());
            r = calcp(b, e);
            Console.WriteLine("\nA potencia de {0} na {1} é: {2}", b, e, r);
            Console.ReadKey();
        }
        static double calcp(double b, double e) {
            double r = 1;
            if (e == 0) {
                r = 1;
            } else {
                for (int i = 0; i < e; i++) {
                    r *= b;
                }
            }
            return r;
        }
    }
}

