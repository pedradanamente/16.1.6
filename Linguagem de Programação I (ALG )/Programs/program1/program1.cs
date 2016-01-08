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

            Console.WriteLine("Digite o peso da Prova:");
            pesoProva = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o peso do Trabalho");
            pesoTrabalho = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota da prova:");
            notaProva = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do Trabalho");
            notaTrabalho = Convert.ToDouble(Console.ReadLine());
            calculaUP = (pesoTrabalho*notaTrabalho) + (pesoProva*notaProva);
            calculaDOWN = pesoProva + pesoTrabalho;
            calculaFIM = calculaUP / calculaDOWN;
            Console.WriteLine("A média ponderada é: {0}", calculaFIM);
            Console.ReadKey();

        }
    }
}
