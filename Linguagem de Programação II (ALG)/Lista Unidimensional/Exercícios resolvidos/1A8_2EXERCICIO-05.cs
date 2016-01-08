using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            const int t = 50;
            int[] arr = new int[t];
            int i;
            int vmaior, imaior, vmenor, imenor;
            vmaior = 0;
            imaior = 0;
            vmenor = 0;
            imenor = 0;
            for (i = 0; i < t; i++) {
                Console.WriteLine("Digite um valor:");
                arr[i] = Convert.ToInt16(Console.ReadLine());
                if (i == 0) {
                    vmaior = arr[i];
                    imaior = i;
                    vmenor = arr[i];
                    imenor = i;
                } else if (arr[i] > vmaior) {
                    vmaior = arr[i];
                    imaior = i;
                } else if (arr[i] < vmenor) {
                    vmenor = arr[i];
                    imenor = i;
                }
            }
            Console.WriteLine("O elemento maior eh {0} de indice {1}", vmaior, imaior);
            Console.WriteLine("O elemento menor eh {0} de indice {1}", vmenor, imenor);
            Console.ReadKey();
        }
    }
}
