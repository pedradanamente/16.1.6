using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaProva, notaTrabalho, pesoProva, pesoTrabalho;
            double calculaUP, calculaDOWN, calculaFIM;
            int i;

            Console.WriteLine("Digite o peso da Prova:");
            pesoProva = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o peso do Trabalho:");
            pesoTrabalho = Convert.ToDouble(Console.ReadLine());
            for (i = 1; i <= 25; i++) {
                Console.WriteLine("[ALUNO: {0}] Digite a nota da prova:", i);
                notaProva = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("[ALUNO: {0}] - Digite a nota do Trabalho", i);
                notaTrabalho = Convert.ToDouble(Console.ReadLine());
                calculaUP = (pesoTrabalho * notaTrabalho) + (pesoProva * notaProva);
                calculaDOWN = pesoProva + pesoTrabalho;
                calculaFIM = calculaUP / calculaDOWN;
                Console.WriteLine("[ALUNO: {0}] A média ponderada é: {1}", i, calculaFIM);
                Console.ReadKey();
            }
            Console.WriteLine("FIM");
            Console.ReadKey();
        }
    }
}
