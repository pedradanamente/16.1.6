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
            /*Escreva um programa que receba a idade de 100 pessoas e informe se cada uma delas é MAIOR DE IDADE,
MENOR DE IDADE ou se é MAIOR DE 65 anos.*/
            int i, idade;
            for (i = 1; i <= 100; i++) {
                Console.WriteLine("[{0}] Digite sua idade:",i);
                idade = Convert.ToInt16(Console.ReadLine());
                if ((idade >= 18)&&(idade<=65)) {
                    Console.WriteLine("Maior de idade");
                } else if (idade < 18) {
                    Console.WriteLine("Menor de idade");
                } else if (idade > 65) {
                    Console.WriteLine("Maior de 65 anos");
                }
                Console.WriteLine("Para seguir em frente pressiona enter.");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
