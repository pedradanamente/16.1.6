using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            int i, y, x, LINHA;
            x = 0;
            Console.WriteLine("DIGITE UM NUMERO DE LINHAS:");
            LINHA = Convert.ToInt16(Console.ReadLine());
            for (i=1;i<=LINHA;i++) {
                for (y = 1; y <= i;y++ ) {
                    x++;
                    Console.Write("{0} \t",x);
                    if (y == i) {
                        Console.WriteLine(x);
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
