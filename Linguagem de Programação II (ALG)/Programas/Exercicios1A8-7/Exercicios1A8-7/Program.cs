using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            const int t = 100;
            int[] arr0 = new int[t];
            int[] arr1 = new int[t];
            int i, n;
            string par, impar;
            par = "";
            impar = "";
            for (i = 0; i < t; i++) {
                arr0[i] = 1;
            }
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite um valor para {0}:", i);
                n = Convert.ToInt16(Console.ReadLine());
                if (n % 2 == 0) {
                    arr0[i] = n;
                    par = par + arr0[i];
                } else {
                    arr1[i] = n;
                    impar = impar + arr1[i];
                }
            }
            for (i = 0; i < t; i++) {
                if (arr0[i] != 1) {
                    Console.WriteLine("Vetor PAR indice: {0}, elemento: {1}", i, arr0[i]);
                }
            }
            for (i = 0; i < t; i++) {
                if (arr1[i] != 0) {
                    Console.WriteLine("Vetor IMPAR indice: {0}, elemento: {1}", i, arr1[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
