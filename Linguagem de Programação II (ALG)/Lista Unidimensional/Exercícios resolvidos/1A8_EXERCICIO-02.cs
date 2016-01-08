using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            const int t = 5;
            int[] myArray = new int[t];
            int i, negativos;
            negativos = 0;
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite um valor p/ o indice {0}:", i);
                myArray[i] = Convert.ToInt16(Console.ReadLine());
                if (myArray[i] < 0) {
                    negativos++;
                }
            }
            Console.WriteLine("O vetor tem um total de {0} elementos negativos", negativos);
            Console.ReadKey();
        }
    }
}
