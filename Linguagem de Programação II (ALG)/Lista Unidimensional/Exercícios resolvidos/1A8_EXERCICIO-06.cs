using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            const int t = 20;
            int[] myArray = new int[t];
            int i, j, aux;
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite um valor p/ o indice {0}:", i);
                myArray[i] = Convert.ToInt16(Console.ReadLine());
            }
            j = t - 1;
            for (i = 0; i < t/2; i++) {
                aux = myArray[i];
                myArray[i] = myArray[j];
                myArray[j] = aux;
                j--;
            }
            for (i = 0; i < t; i++) {
                Console.WriteLine("O indice {0} foi modificado para {1}", i, myArray[i]);
            }
            Console.ReadKey();
        }
    }
}
