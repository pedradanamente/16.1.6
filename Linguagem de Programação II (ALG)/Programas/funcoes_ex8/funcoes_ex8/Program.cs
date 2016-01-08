using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class program
    {
        static void Main(string[] args) {
            int x, numero, quantidade = 0, r;
            do {
                Console.WriteLine("Escreva um numero:");
                numero = Convert.ToInt16(Console.ReadLine());
                x = 1;
                while (x <= numero) {
                    r = verificaPrimo(x, quantidade);
                    if (r == 1) {
                        quantidade++;
                    }
                    x++;
                }
                Console.WriteLine("Foi encontrado {0} numeros primos!", quantidade);
                quantidade = 0;
            } while (numero != 0);
            Console.ReadKey();
        }

        static int verificaPrimo(int x, int quantidade) {
            int verifica = 0, i, r;
            for (i = 1; i <= x; i++) {
                if (x % i == 0) {
                    verifica++;
                }
            }
            if (verifica == 2) {
                Console.WriteLine("[{0}] - O número {1} é primo!", ++quantidade, x);
                r = 1;
            } else {
                r = 0;
            }
            return r;
        }

    }
}
