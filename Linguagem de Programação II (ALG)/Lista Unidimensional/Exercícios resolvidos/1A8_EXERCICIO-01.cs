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
            int[] myArray = new int[t];
            int i;
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite o valor p/ o indice {0}:",i);
                myArray[i]=Convert.ToInt16(Console.ReadLine());
            }
            for (i = 0; i < t; i++) {
                Console.WriteLine("O elemento do indice {0} é: {1}",i,myArray[i]);
            }
            Console.ReadKey();
        }
    }
}
