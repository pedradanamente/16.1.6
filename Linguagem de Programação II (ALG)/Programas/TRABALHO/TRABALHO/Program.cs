﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            const int t = 4;
            int[] myArray = new int[t];
            int opcao = 0, q = 0, opcount = 0;
            do {
                if (((opcao<=0)||(opcao>5))&&(opcount!=0)) {
                    Console.WriteLine("Parâmetro inválido!");
                }
                opcount++;
                opcao = menu();
                q = escolhe(opcao, t, q, myArray);
            } while ((opcao > 0) && (opcao < 6) || (q>-1));
                Console.ReadKey();
        }
        //procedimento que mostra o menu
        static int menu() {
            int r;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("MENU:");
            Console.WriteLine("(1) Incluir valor");
            Console.WriteLine("(2) Pesquisar valor");
            Console.WriteLine("(3) Excluir Valor");
            Console.WriteLine("(4) Ordenar valores no vetor");
            Console.WriteLine("(5) Mostrar vetor");
            Console.WriteLine("(6) Sair");
            Console.WriteLine("--------------------------------");
            r = Convert.ToInt16(Console.ReadLine());
            return r;
        }
        //funcao que substitui de swtich case para escolha do menu de 1 a 5
        static int escolhe(int opcao, int t, int q, int[] myArray) {
            int i, p = 0;
            //opcao 1
            if (opcao == 1) {
                if (q == t) {
                    Console.WriteLine("Você excedeu o limite do vetor!");
                } else {
                    Console.Write("Digite um valor para adicionar: ");
                    myArray[q] = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("O valor {0} foi adicionado no indice {1}", myArray[q], q);
                    q++;
                }
            }
            //opcao 2
            if (opcao == 2) {
                int pesquisa;
                Console.Write("Digite um valor para pesquisa no vetor: ");
                pesquisa = Convert.ToInt16(Console.ReadLine());
                for (i = 0; i < t; i++) {
                    if (myArray[i] == pesquisa) {
                        Console.WriteLine("O valor {0} foi encontrado no indice {1}", myArray[i], i);
                        p++;
                    }
                }
                if (p==0) {
                    Console.WriteLine("Valor não encontrado");
                }
            }
            //opcao 3
            if (opcao == 3) {
                int exclusao;
                Console.Write("Digite um valor para exclusao do vetor: ");
                exclusao = Convert.ToInt16(Console.ReadLine());
                for (i = 0; i < t; i++) {
                    if (myArray[i] == exclusao) {
                        Console.WriteLine("O valor {0} foi excluido, estava no indice {1}", myArray[i], i);
                        myArray[i] = 0;
                        p++;
                    }
                }
                if (p == 0) {
                    Console.WriteLine("Valor não encontrado");
                }
            }
            //opcao 4
            if (opcao == 4) {
                int aux, j;
                for(i=0; i<t; i++) {
                    for(j=0; j<t-1; j++) {
                        if(myArray[j]>myArray[j+1]){
                            aux=myArray[j];
                            myArray[j]=myArray[j+1];
                            myArray[j+1] = aux;
                        }
                    }
                }
                Console.WriteLine("Vetor ordenado!");
            }
            //opcao 5
            if (opcao == 5) {
                Console.WriteLine("Vetor:");
                for (i = 0; i < t; i++) {
                    if (myArray[i] != 0) {
                        Console.Write("{0} ", myArray[i]);
                    }
                }
                Console.WriteLine("");
            }
            //opcao 6
            if (opcao==6) {
                Console.WriteLine("Você saiu do sistema.");
                q = -1;
            }
            //retorno da funcao de escolha de menu
            return q;
        }


    }
}
