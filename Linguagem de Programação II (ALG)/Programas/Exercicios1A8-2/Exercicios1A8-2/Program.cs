using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            const int t = 15;
            int q = 0;
            int[] arr = new int[t];
            int i;
            Console.WriteLine("Digite os 15 valores para preencher o vetor:");
            for (i = 0; i < t; i++) {
                arr[i] = Convert.ToInt16(Console.ReadLine());
                if (arr[i] < 0) {
                    q++;
                }
            }
            Console.WriteLine("Total de {0} elementos negativos", q);
            Console.ReadKey();
        }
    }
}
