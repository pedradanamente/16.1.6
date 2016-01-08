using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            const int t = 25;
            int[] arr0 = new int[t];
            int[] arr1 = new int[t];
            int[] arr3 = new int[t * 2];
            int i, x;
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite um valor para {0} no primeiro vetor:", i);
                arr0[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite um valor para {0} no segundo vetor:", i);
                arr1[i] = Convert.ToInt16(Console.ReadLine());
            }
            x = 0;
            for (i = 0; i < t * 2; i = i + 2) {
                arr3[i] = arr0[x];
                x = x + 1;
            }
            x = t - 1;
            for (i = 1; i < t * 2; i = i + 2) {
                arr3[i] = arr1[x];
                x = x - 1;
            }
            for (i = 0; i < t; i++) {
                Console.WriteLine("Vetor 3 indice: {0}, elemento: {1}", i, arr3[i]);
            }
            Console.ReadKey();
        }
    }
}
