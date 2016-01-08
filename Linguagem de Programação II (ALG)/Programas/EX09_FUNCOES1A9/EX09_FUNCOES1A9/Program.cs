using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            /*9. Escreva um programa em que a função main solicite ao usuário três valores inteiros (a, b e c)
onde a é maior que 1. Uma outra função deverá somar todos os inteiros entre b e c que sejam
divisíveis por a. A função maindeve informar o resultado da soma.*/
            int a, b, c, r;
            do {
                Console.WriteLine("Digite um valor para A:");
                a = Convert.ToInt16(Console.ReadLine());
            } while (a <= 1);
            Console.WriteLine("Digite um valor para B:");
            b = Convert.ToInt16(Console.ReadLine());
            do {
                Console.WriteLine("Digite um valor para C:");
                c = Convert.ToInt16(Console.ReadLine());
            } while (c <= b);
            r = soma(b, c, a);
            Console.WriteLine("Resultado da soma: {0}", r);
            Console.ReadKey();
        }

        static int soma(int b, int c, int a) {
            int i, r = 0;
            for (i = b + 1; i < c; i++) {
                Console.WriteLine("Intervalo: {0}", i);
                if (i % a == 0) {
                    r += i;
                }
            }
            return r;
        }
    }

}
