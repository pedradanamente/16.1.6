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
            int i,n,x;
            n = 0;
            x = 0;
            for (i=0;i<t;i++){
                Console.WriteLine("Digite um valor para o elemento no indice {0}:",i);
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Digite um numero:");
            n = Convert.ToInt16(Console.ReadLine());
            while(n!=0) {
                x = 0;
                for (i = 0; i < t; i++) {
                    if (arr[i] == n) {
                        Console.WriteLine("O numero {0} foi encontrado no indice {1}", n, i);
                        x++;
                    }
                }
                if (x == 0) {
                    Console.WriteLine("O numero {0} nao foi encontrado", n, x);
                }
                Console.WriteLine("Digite um numero novamente:");
                n = Convert.ToInt16(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
