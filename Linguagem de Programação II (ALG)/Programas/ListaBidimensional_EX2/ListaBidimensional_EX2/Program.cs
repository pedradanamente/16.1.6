using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            const int TL = 2;
            const int TC = 2;
            int[,] myArray = new int[TL, TC];
            int i, j, l, c, r = 0;
            for (i = 0; i < TL; i++) {
                for (j = 0; j < TC; j++) {
                    Console.WriteLine("Digite um valor p/ o indice de Linha {0} e Coluna {1}:", i, j);
                    myArray[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            do {
                Console.WriteLine("Digite uma primeira Linha:");
                l = Convert.ToInt16(Console.ReadLine());
            } while (l < 0 || l >= TL);
            do {
                Console.WriteLine("Digite uma primeira Coluna:");
                c = Convert.ToInt16(Console.ReadLine());
            } while (c < 0 || c >= TC);
            Console.WriteLine("Valor selecionado: {0}", myArray[l, c]);
            r += myArray[l, c];
            do {
                Console.WriteLine("Digite uma segunda Linha:");
                l = Convert.ToInt16(Console.ReadLine());
            } while (l < 0 || l >= TL);
            do {
                Console.WriteLine("Digite uma seguna Coluna:");
                c = Convert.ToInt16(Console.ReadLine());
            } while (c < 0 || c >= TC);
            Console.WriteLine("Valor selecionado: {0}", myArray[l, c]);
            r += myArray[l, c];
            Console.WriteLine("A soma dos valores selecionados é: {0}", r);
            Console.ReadKey();
        }
    }
}
