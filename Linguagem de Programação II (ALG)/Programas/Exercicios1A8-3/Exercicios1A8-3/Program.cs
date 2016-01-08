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
            int q = 0;
            int[] arr = new int[t];
            int i;
            Console.WriteLine("Digite 10 valores para preencher o vetor:");
            for (i = 0; i < t; i++) {
                arr[i] = Convert.ToInt16(Console.ReadLine());
                if (arr[i] == 10) {
                    q++;
                }
            }
            Console.WriteLine("Total de {0} elementos iguais a 10", q);
            Console.ReadKey();
        }
    }
}
