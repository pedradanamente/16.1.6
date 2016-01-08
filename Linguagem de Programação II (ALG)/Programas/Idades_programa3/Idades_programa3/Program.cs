using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            /* ESCREVA UM PROGRAMA QUE RECEBE A IDADE DE 100 PESSOAS E INFORMA
             * SE CADA UMA DELAS É MAIOR DE IDADE, MENOR DE IDADE OU MAIOR DE 65 ANOS */

            int x, idade;
            for (x = 1; x <= 100; x++) {
                Console.WriteLine("Digite a idade:");
                idade = int.Parse(Console.ReadLine());
                if ((idade >= 18)&&(idade<=65)) {
                    Console.WriteLine("{0} - MAIOR DE IDADE", x);
                }
                else if (idade < 18) {
                    Console.WriteLine("{0} - MENOR DE IDADE", x);
                }
                else if (idade > 65) { Console.WriteLine("{0} - MAIOR DE 65 ANOS",x); }
            }
            Console.ReadKey();
        }
    }
}
