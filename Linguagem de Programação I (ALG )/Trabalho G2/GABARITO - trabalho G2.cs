/*Questão 1 - trabalho A)No algoritmo a seguir, quantas vezes é impresso “Olá”? 
Resposta: ____9 vezes___________

j=2;
k=5;
n=9;
enquanto (j < k) faça
inicio
	m = 6;
	enquanto (m < n) faça
	inicio
		escreva (“Olá”);
		m = m + 1;
	fim
	j = j + 1;
fim

Questão 1 - trabalho B)No algoritmo a seguir, quantas vezes é impresso “Olá”? 
Resposta: ____3 vezes___________


j=2;
k=5;
m=6;
n=9;
enquanto (j < k) faça
inicio
	enquanto (m < n) faça
	inicio
		escreva (“Olá”);
		m = m + 1;
	fim
	j = j + 1;
fim

Questão 2)
*/
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
            int quantBarato = 0, quantNormal=0, quantCaro=0, quantProdutos = 0, encerrar;
            decimal preco, custoEst=0, precoFinal, imposto, adicional=0, maiorP=0, menorP=0, totalImp=0;            
            string refri, categ;
            Console.WriteLine("Encerrar programa? 1-Sim 2-Não");
            encerrar = Convert.ToInt16(Console.ReadLine());
            while (encerrar !=1)
            {
                if (encerrar != 2 && encerrar !=1)
                    Console.WriteLine("Opção Inválida! Tente novamente!");
                else                
                {
                    Console.Write("PREÇO: ");
                    preco = Convert.ToDecimal(Console.ReadLine());
                    do//controla a entrada da refrigeração
                    {
                        Console.WriteLine("REFRIGERAÇÃO:\nS - produtos que precisam \nN - produtos que não precisam");
                        refri = Console.ReadLine();
                    } while (refri != "S" && refri != "N");
                    do//controla a entrada da categoria
                    {
                        Console.WriteLine("CATEGORIA:\nA - alimentação \nL - limpeza \nV - vestuário ");
                        categ = Console.ReadLine();
                    } while (categ != "A" && categ != "L" && categ != "V");
                    quantProdutos++;//incrementa a quantidade de produtos
                    //verifica o custo de estocagem (a)
                    if (preco <= 20)
                    {
                        if (categ == "A")
                            custoEst = 2;
                        else if (categ == "L")
                            custoEst = 3;
                        else if (categ == "V")
                            custoEst = 4;
                    }
                    else if (preco > 20 && preco <= 50)
                    {
                        if (refri == "S")
                            custoEst = 6;
                        else
                            custoEst = 0;
                    }
                    else if (preco > 50)
                    {
                        if (refri == "S")
                        {
                            if (categ == "A")
                                custoEst = 5;
                            else if (categ == "L")
                                custoEst = 2;
                            else if (categ == "V")
                                custoEst = 4;
                        }
                        else
                        {
                            if (categ == "A" || categ == "V")
                                custoEst = 0;
                            else if (categ == "L")
                                custoEst = 1;
                        }
                    }//fim da verificação do custo de estocagem

                    //calcula o imposto (b)
                    if (categ != "A" && refri != "S")
                        imposto = preco * 2 / 100;
                    else
                        imposto = preco * 4 / 100;

                    //calcula o preço final (c)
                    precoFinal = preco + custoEst + imposto;
                    Console.WriteLine("CUSTO ESTOCAGEM: " + custoEst);
                    Console.WriteLine("IMPOSTO: " + imposto);
                    Console.WriteLine("PREÇO FINAL: " + precoFinal);

                    //verifica a classificação (d)
                    if (precoFinal <= 20)
                    {
                        quantBarato++;//letra i
                        Console.WriteLine("CLASSIFICAÇÃO: BARATO");
                    }
                    else if (precoFinal > 20 && precoFinal <= 100)
                    {
                        quantNormal++;//letra j
                        Console.WriteLine("CLASSIFICAÇÃO: NORMAL");
                    }
                    else if (precoFinal > 100)
                    {
                        quantCaro++;//letra k
                        Console.WriteLine("CLASSIFICAÇÃO: CARO");
                    }//fim da verificação da classificação
                    
                    //somatorio dos valores adicionais (e)
                    adicional = adicional + custoEst + imposto;

                    //calcula o total de impostos (h)
                    totalImp = totalImp + imposto;

                    //verifica menor e maior preco final (f e g)
                    if (quantProdutos == 1)
                    {
                        maiorP = precoFinal;
                        menorP = precoFinal;
                    }
                    else
                    {
                        if (precoFinal > maiorP)
                            maiorP = precoFinal;
                        if (precoFinal < menorP)
                            menorP = precoFinal;
                    }//fim da verificação de maior e menor preco final
                }
                
                Console.WriteLine("Encerrar programa? 1-Sim 2-Não");
                encerrar = Convert.ToInt16(Console.ReadLine());
            }
            if (quantProdutos > 0)
            {
                adicional = adicional / quantProdutos;
                Console.WriteLine("ADICIONAL: " + adicional);
                Console.WriteLine("MAIOR PREÇO: " + maiorP);
                Console.WriteLine("MENOR PREÇO: " + menorP);
                Console.WriteLine("TOTAL DE IMPOSTOS: " + totalImp);
                Console.WriteLine("QUANTIDADE DE PRODUTOS BARATOS: " + quantBarato);
                Console.WriteLine("QUANTIDADE DE PRODUTOS NORMAIS: " + quantNormal);
                Console.WriteLine("QUANTIDADE DE PRODUTOS CAROS: " + quantCaro);
            }
            Console.ReadKey();
        }
    }
}

