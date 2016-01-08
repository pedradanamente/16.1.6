using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class program
    {
        static void Main(string[] args) {
            int x, numero, q = 1, r;
            do {
                Console.Write("Escreva um numero: ");
                numero = Convert.ToInt16(Console.ReadLine());
                x = 1;
                while (q <= numero) {
                    r = primo(x);
                    if (r == 1) {
                        Console.Write("{0} ", x);
                        q++;
                    }
                    x++;
                }
                Console.WriteLine("\nBusquei pelos {0} primeiros numeros primos!", --q);
                q = 1;
            } while (numero != 0);
            Console.ReadKey();
        }

        static int primo(int x) {
            int verifica = 0, i, r;
            for (i = 1; i <= x; i++) {
                if (x % i == 0) {
                    verifica++;
                }
            }
            if (verifica == 2) {
                r = 1;
            } else {
                r = 0;
            }
            return r;
        }
    }
}
