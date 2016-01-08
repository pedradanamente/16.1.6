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
            int numero, i;
            bool search = false;
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite um valor p/ o indice {0}:",i);
                myArray[i] = Convert.ToInt16(Console.ReadLine());
            }
            do {
                Console.WriteLine("Digite um número para buscar no vetor: ");
                numero = Convert.ToInt16(Console.ReadLine());
                for (i = 0; i < t; i++) {
                    if (numero == myArray[i]) {
                        Console.WriteLine("O numero {0} foi encontrado na posicao {1}.", numero, i);
                        search = true;
                    }
                }
                if (search == false) {
                    Console.WriteLine("O numero {0} nao foi encontrado", numero);
                }
            } while (numero != 0);
            Console.ReadKey();
        }
    }
}
