using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            int A, B;
            Console.WriteLine("Digite um número para A:");
            A = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite um numero para B:");
            B = Convert.ToInt16(Console.ReadLine());
            if ((A%B==0)||(B%A==0)) {
                Console.WriteLine("São multiplos");
            }else { Console.WriteLine("Não são multiplos"); }
            Console.ReadKey();
        }
    }
}
