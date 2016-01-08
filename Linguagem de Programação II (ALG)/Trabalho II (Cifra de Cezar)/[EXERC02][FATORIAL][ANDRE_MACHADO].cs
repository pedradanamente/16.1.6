using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /* TRABALHO II DE ALGORITMOS II, 17/09/2014
    /* --------------------------------------------------------------------------------------------------- *
    Sabendo que fatorial de um número é: 
    7! = 7*6*5*4*3*2*1
    4! = 4*3*2*1
    * ---------------------------------------------------------------------------------------------------- */
    class Program
    {
        static void Main(string[] args) {
            int value, r;
            do {
                Console.WriteLine("Digite um valor para calcular o fatorial:");
                value = Convert.ToInt16(Console.ReadLine());
				if (value < 0) {
					Console.WriteLine("Parâmetro não calculavel");
				}else {
					r = fatorial(value);
					Console.WriteLine("Fatorial de {0} é: {1}", value, r);
				}
            } while (value != -1);
            Console.ReadKey();
        }

        static int fatorial(int value) {
            int i, r;
            r = value;
            if (r == 0) {
                r = 1;
            } else {
				for (i = value - 1; i > 0; i--) {
					r *= i;
				}
			}
            return r;
        }

    }
}
