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
            int[] arr = new int[t];
            int i;
            Console.WriteLine("Digite {0} valores para preencher o vetor:",t);
            for (i = 0; i < t; i++) {
                arr[i] = Convert.ToInt16(Console.ReadLine());
                if (arr[i] == 0) {
                    arr[i] = 1;
                }
            }
            for (i = 0; i < t; i++) {
                Console.Write("{0}\t", arr[i]);
            }
            Console.ReadKey();
        }
    }
}
