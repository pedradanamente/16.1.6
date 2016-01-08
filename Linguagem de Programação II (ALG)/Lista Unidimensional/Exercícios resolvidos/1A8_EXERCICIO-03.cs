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
            int i, contador;
            contador = 0;
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite um valor p/ o indice {0}:",i);
                myArray[i]=Convert.ToInt16(Console.ReadLine());
                if (myArray[i] == 10) {
                    contador++;
                }
            }
            Console.WriteLine("O numero 10 aparece {0} vezes no vetor", contador);
            Console.ReadKey();
        }
    }
}
