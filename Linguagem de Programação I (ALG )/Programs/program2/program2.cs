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
            int A;
            double B, C, D, RESULTADO;

            Console.WriteLine("Digite um valor:");
            A = Convert.ToInt16(Console.ReadLine());
            if ((A == 1) || (A == 2) || (A == 3)) {
                Console.WriteLine("Digite um valor para B:");
                B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite um valor para C:");
                C = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite um valor para D:");
                D = Convert.ToDouble(Console.ReadLine());
                if (A == 1) {
                    RESULTADO = (B + C + D) / 3;
                    Console.WriteLine("A média aritmética é: {0}", RESULTADO);
                }
                else if (A == 2) {
                    RESULTADO = B + C + D;
                    Console.WriteLine("A soma é: {0}", RESULTADO);
                }
                else if (A == 3) {
                    if (B % 2 == 0) {
                        Console.WriteLine("O valor de B é par.");
                    }
                    else {
                        Console.WriteLine("O valor de B é impar");
                    }
                }
            }
            else {
                Console.WriteLine("Valor Inválido!");
            }
            Console.ReadKey();
        }
    }
}
