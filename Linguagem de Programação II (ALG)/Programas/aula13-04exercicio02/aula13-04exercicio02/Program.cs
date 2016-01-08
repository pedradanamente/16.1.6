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
            int[] arr = new int[t];
            int i, search, x;
            x = 0;
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite um valor para o elemento no indice {0}:", i);
                arr[i] = Convert.ToInt16(Console.ReadLine());
                for (search = 0; search < t; search++) {
                    if ((arr[search] == arr[i])&&(i!=search)) {
                        x++;
                    }
                }
                if (x > 0) {
                    Console.WriteLine("Numero repetido");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
