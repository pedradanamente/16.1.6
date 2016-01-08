using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            int value, r;
            do {
                Console.WriteLine("Digite um valor para calcular o fatorial:");
                value = Convert.ToInt16(Console.ReadLine());
                r = fatorial(value);
                Console.WriteLine("Fatorial de {0} é: {1}", value, r);
            } while (value >= 0);
            Console.ReadKey();
        }
        static int fatorial(int value) {
            int i, x, r;
            x = value;
            for (i = value - 1; i > 0; i--) {
                x *= i;
            }
            r = x;
            return r;
        }
    }
}
