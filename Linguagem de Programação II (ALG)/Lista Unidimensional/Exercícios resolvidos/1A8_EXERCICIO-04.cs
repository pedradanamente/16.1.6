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
            int i;
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite um valor p/ o indice {0}",i);
                myArray[i] = Convert.ToInt16(Console.ReadLine());
                if (myArray[i] == 0) {
                    myArray[i] = 1;
                }
            }
            for (i = 0; i < t; i++) {
                Console.WriteLine("O elemento de indice {0} é: {1}",i,myArray[i]);
            }
            Console.ReadKey();
        }
    }
}
