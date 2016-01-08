using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercício:
             * Escreva um programa que leia um numero indeterminado de valores e conte quantos valores pares
             * foram informados, quantos valores impares e o total de valores informados.
             * O valor de finalização deve ser a entrada do numero zero.
             */
            int numero, pares, impares, total;
            total = 0;  pares = 0;  impares = 0;
            Console.WriteLine("Digite um numero:");
            numero = Convert.ToInt16(Console.ReadLine());
            while (numero != 0) {
                total++;
                if (numero % 2 == 0) {
                    pares++;
                }
                else {
                    impares++;
                }
                Console.WriteLine("Digite outro numero:");
                numero = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("O total de numeros foi {0}, e pares foi {1} e impares foi {2}",total,pares,impares);
            Console.ReadKey();
        }
    }
}
