﻿/*4) A prefeitura de uma cidade deseja fazer uma pesquisa entre seus 
 * habitantes. Faça um programa para coletar 
 * dados sobre o salário e número de filhos de cada habitante e 
 * após as leituras, escrever:
1. Média de salário da população
2. Média do número de filhos
3. Maior salário dos habitantes
4. Percentual de pessoas com salário menor que R$ 150,00
Obs.: usar comando for (1000 habitantes)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TOTALH = 5000;
            decimal salario, somaSalario = 0, maiorSalario=0;
            int x, numFilhos, somaFilhos = 0, numHabSalMenor150 = 0;                       
            for(x=1;x<=TOTALH;x++)
            {
                Console.WriteLine("Digite o salário do habitante:");
                salario = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Digite o número de filhos do habitante: ");
                numFilhos = int.Parse(Console.ReadLine());                
                somaSalario = somaSalario + salario;
                somaFilhos = somaFilhos + numFilhos;
                if (salario < 150)
                    numHabSalMenor150++;
                if ((salario > maiorSalario)||(x==1))
                    maiorSalario = salario;                
            }            
            Console.WriteLine("a média de salário da população é: {0:C}", somaSalario / TOTALH );
            Console.WriteLine("A média do número de filhos da população é: " + (double)somaFilhos / TOTALH);
            Console.WriteLine("O maior salário da população é {0:C}", maiorSalario);
            Console.WriteLine("O percentual de hatibantes com salário < R$ 150,00 é " + (double)(numHabSalMenor150 * 100) / TOTALH + "%");            
            Console.WriteLine("Tecle algo para sair");
            Console.ReadKey();
        }
    }
}

