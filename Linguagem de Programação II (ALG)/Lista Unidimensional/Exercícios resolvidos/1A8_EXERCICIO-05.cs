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
            int[] myArray = new int[t];
            int i, maiorE = 0, maiorI = 0, menorE = 0, menorI = 0;
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite um valor p/ o indice {0}:",i);
                myArray[i] = Convert.ToInt16(Console.ReadLine());
                if (i == 0) {
                    maiorE = myArray[i];
                    maiorI = i;
                    menorE = myArray[i];
                    menorI = i;
                }
                if (myArray[i] > maiorE) {
                    maiorE = myArray[i];
                    maiorI = i;
                }
                if (myArray[i] < menorE) {
                    menorE = myArray[i];
                    menorI = i;
                }
            }
            Console.WriteLine("O maior elemento é o {0} de indice {1}", maiorE, maiorI);
            Console.WriteLine("O menor elemento é o {0} de indice {1}", menorE, menorI);
            Console.ReadKey();
        }
    }
}
