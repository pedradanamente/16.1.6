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
            int[] myArray1 = new int[t];
            int[] myArray2 = new int[t];
            int[] myArray3 = new int[t*2];
            int i, x;
            for (i = 0; i < t;i++) {
                Console.WriteLine("Digite um valor p/ o indice {0} do primeiro vetor:",i);
                myArray1[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite um valor p/ o indice {0} do segundo vetor:", i);
                myArray2[i] = Convert.ToInt16(Console.ReadLine());
            }
            x = 0;
            for (i = 0; i < t * 2; i = i + 2) {
                myArray3[i] = myArray1[x];
                x++;
            }
            x = 0;
            for (i = 1; i < t * 2; i = i + 2) {
                myArray3[i] = myArray2[x];
                x++;
            }
            Console.Write("TERCEIRO VETOR: ");
            for (i = 0; i < t*2; i++) {
                Console.Write("{0} ", myArray3[i]);
            }
            Console.ReadKey();
        }
    }
}
