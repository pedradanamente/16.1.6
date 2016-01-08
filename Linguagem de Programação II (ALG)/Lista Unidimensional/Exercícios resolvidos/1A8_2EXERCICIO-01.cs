using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            const int t = 10;
            int[] arr = new int[t];
            int i;
            Console.WriteLine("Digite os 10 valores para preencher o vetor:");
            for (i = 0; i < t; i++) {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (i = 0; i < t; i++) {
                Console.WriteLine("Ordem {0} elemento {1}", i, arr[i]);
            }
            Console.ReadKey();
        }
    }
}
