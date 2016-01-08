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
            int i, j, contador = 0;
            bool repetido = false;
            for (i = 0; i < t; i++) {
                do {
                    repetido = false;
                    Console.WriteLine("Digite um valor p/ o indice {0}", i);
                    myArray[i] = Convert.ToInt16(Console.ReadLine());
                    for (j = 0; j < t; j++) {
                        if ((myArray[i] == myArray[j]) && (i != j)) {
                            repetido = true;
                        }
                    }
                    if (repetido == true) {
                        Console.WriteLine("Numero repetido!");
                    }
                }while(repetido==true);
            }
            Console.Write("VETOR: ");
            for (i = 0; i < t; i++) {
                Console.Write("{0} ", myArray[i]);
            }
            Console.ReadKey();
        }
    }
}
