using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            const int TL = 5;
            const int TC = 5;
            int[,] myArray = new int[TL, TC];
            int i, j;
            for (i = 0; i < TL; i++) {
                for (j = 0; j < TC; j++) {
                    if (j == i) {
                        myArray[i, j] = 1;
                    } else {
                        myArray[i, j] = 0;
                    }
                }
            }
            for (i = 0; i < TL; i++) {
                for (j = 0; j < TC; j++) {
                    Console.Write("{0} \t", myArray[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
