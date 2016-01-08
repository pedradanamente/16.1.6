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
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite um valor para {0}:",i);
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            Array.Reverse(arr);
            for (i = 0; i < t; i++) {
                Console.WriteLine("Indice {0} elemento {1}", i, arr[i]);
            }
            Console.ReadKey();
        }
    }
}
