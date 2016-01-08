using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            const int t=100;
            int[] myArrayPAR = new int[t];
            int[] myArrayIMPAR = new int[t];
            int i, c_PAR = 0, c_IMPAR = 0, valor;
            for(i=0;i<t;i++){
                Console.WriteLine("Digite um valor p/ o indice {0}",i);
                valor=Convert.ToInt16(Console.ReadLine());
                if (valor%2==0){
                    myArrayPAR[c_PAR]=valor;
                    c_PAR++;
                }
                else {
                    myArrayIMPAR[c_IMPAR]=valor;
                    c_IMPAR++;
                }
            }
            for (i=0;i<c_PAR;i++){
                Console.WriteLine("O elemento do indice {0} no vetor par é: {1}", i, myArrayPAR[i]);
            }
            for (i=0;i<c_IMPAR;i++){
                Console.WriteLine("O elemento do indice {0} no vetor impar é: {1}", i, myArrayIMPAR[i]);
            }
            Console.ReadKey();
        }
    }
}
