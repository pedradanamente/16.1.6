using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            int QUANTIDADE, _barato, _normal, _caro;
            double valorUN, valorESTOQUE, imposto, impostoTOTAL, mediaIMPOSTO, menorValorTOTAL, maiorValorTOTAL, custoESTOQUETOTAL, mediaCUSTOESTOCAGEM, valorFINAL, valorTOTAL;
            string refrigeracao, categoria, continua, classificacao;

            impostoTOTAL = 0;
            QUANTIDADE = 0;
            menorValorTOTAL = 0;
            maiorValorTOTAL = 0;
            custoESTOQUETOTAL = 0;
            valorESTOQUE = 0;
            valorFINAL = 0;
            valorTOTAL = 0;
            imposto = 0;
            _barato = 0;
            _normal = 0;
            _caro = 0;
            classificacao = "DEBUG";
            continua = "S";
            while (continua == "S") {
                QUANTIDADE++;
                Console.WriteLine("Digite o preco unitario:");
                valorUN = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Possui refrigeracao? S/N");
                refrigeracao = Console.ReadLine();
                Console.WriteLine("Qual a categoria? A, L, V");
                categoria = Console.ReadLine();
                //processo
                switch (categoria) {
                    case "A":
                        if (valorUN <= 20) {
                            valorESTOQUE = 2.00;
                            imposto = (valorESTOQUE / 100) * 2;
                            valorFINAL = valorESTOQUE + imposto + valorUN;
                            custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                            break;
                        } else if ((valorUN > 20) && (valorUN <= 50)) {
                            switch (refrigeracao) {
                                case "S":
                                    valorESTOQUE = 6.00;
                                    imposto = (valorESTOQUE / 100) * 2;
                                    valorFINAL = valorESTOQUE + imposto + valorUN;
                                    custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                                    break;
                                case "N":
                                    valorESTOQUE = 0.00;
                                    imposto = (valorESTOQUE / 100) * 4;
                                    valorFINAL = valorESTOQUE + imposto + valorUN;
                                    custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                                    break;
                                default:
                                    //nada
                                    break;
                            }

                        } else if (valorUN > 50) {
                            switch (refrigeracao) {
                                case "S":
                                    valorESTOQUE = 5.00;
                                    imposto = (valorESTOQUE / 100) * 2;
                                    valorFINAL = valorESTOQUE + imposto + valorUN;
                                    custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                                    break;
                                case "N":
                                    valorESTOQUE = 0.00;
                                    imposto = (valorESTOQUE / 100) * 4;
                                    valorFINAL = valorESTOQUE + imposto + valorUN;
                                    custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                                    break;
                                default:
                                    //nada
                                    break;
                            }
                        }
                        break;
                    case "L":
                        if (valorUN <= 20) {
                            valorESTOQUE = 3.00;
                            imposto = (valorESTOQUE / 100) * 4;
                            valorFINAL = valorESTOQUE + imposto + valorUN;
                            custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                            break;
                        } else if ((valorUN > 20) && (valorUN <= 50)) {
                            switch (refrigeracao) {
                                case "S":
                                    valorESTOQUE = 6.00;
                                    imposto = (valorESTOQUE / 100) * 4;
                                    valorFINAL = valorESTOQUE + imposto + valorUN;
                                    custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                                    break;
                                case "N":
                                    valorESTOQUE = 0.00;
                                    imposto = (valorESTOQUE / 100) * 4;
                                    valorFINAL = valorESTOQUE + imposto + valorUN;
                                    custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                                    break;
                                default:
                                    //nada
                                    break;
                            }
                        } else if (valorUN > 50) {
                            switch (refrigeracao) {
                                case "S":
                                    valorESTOQUE = 2.00;
                                    imposto = (valorESTOQUE / 100) * 4;
                                    valorFINAL = valorESTOQUE + imposto + valorUN;
                                    custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                                    break;
                                case "N":
                                    valorESTOQUE = 1.00;
                                    imposto = (valorESTOQUE / 100) * 4;
                                    valorFINAL = valorESTOQUE + imposto + valorUN;
                                    custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                                    break;
                                default:
                                    //nada
                                    break;
                            }
                        }
                        break;
                    case "V":
                        if (valorUN <= 20) {
                            valorESTOQUE = 4.00;
                            imposto = (valorESTOQUE / 100) * 4;
                            valorFINAL = valorESTOQUE + imposto + valorUN;
                            custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                            break;
                        } else if ((valorUN > 20) && (valorUN <= 50)) {
                            switch (refrigeracao) {
                                case "S":
                                    valorESTOQUE = 6.00;
                                    imposto = (valorESTOQUE / 100) * 4;
                                    valorFINAL = valorESTOQUE + imposto + valorUN;
                                    custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                                    break;
                                case "N":
                                    valorESTOQUE = 0.00;
                                    imposto = (valorESTOQUE / 100) * 4;
                                    valorFINAL = valorESTOQUE + imposto + valorUN;
                                    custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                                    break;
                                default:
                                    //nada
                                    break;
                            }
                        } else if (valorUN > 50) {
                            switch (refrigeracao) {
                                case "S":
                                    valorESTOQUE = 4.00;
                                    custoESTOQUETOTAL = valorESTOQUE + custoESTOQUETOTAL;
                                    imposto = (valorESTOQUE / 100) * 4;
                                    valorFINAL = valorESTOQUE + imposto + valorUN;
                                    custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                                    break;
                                case "N":
                                    valorESTOQUE = 0.00;
                                    custoESTOQUETOTAL = valorESTOQUE + custoESTOQUETOTAL;
                                    imposto = (valorESTOQUE / 100) * 4;
                                    valorFINAL = valorESTOQUE + imposto + valorUN;
                                    custoESTOQUETOTAL = custoESTOQUETOTAL + valorESTOQUE;
                                    break;
                                default:
                                    //nada
                                    break;
                            }
                        }
                        break;
                    default:
                        //nada
                        break;
                }
                Console.WriteLine("ITEM NUMERO: {0}",QUANTIDADE);
                if (QUANTIDADE == 1) {
                    menorValorTOTAL = valorFINAL;
                    maiorValorTOTAL = valorFINAL;
                } else if (valorTOTAL > maiorValorTOTAL) {
                    maiorValorTOTAL = valorFINAL;
                    Console.WriteLine("MAIOR VALOR FINAL ATRIBUIDO COM: {0}", maiorValorTOTAL);
                } else if (valorTOTAL < menorValorTOTAL) {
                    menorValorTOTAL = valorFINAL;
                    Console.WriteLine("MENOR VALOR FINAL ATRIBUIDO COM: {0}", menorValorTOTAL);
                }
                Console.WriteLine("CUSTO DE ESTOCAGEM: R$ {0}", valorESTOQUE);
                Console.WriteLine("IMPOSTO: {0}", imposto);
                Console.WriteLine("VALOR FINAL: {0}", valorFINAL);
                if (valorFINAL <= 20) {
                    classificacao = "BARATO";
                    _barato++;
                } else if ((valorFINAL > 20) && (valorFINAL <= 100)) {
                    classificacao = "NORMAL";
                    _normal++;
                } else if (valorFINAL > 100) {
                    classificacao = "CARO";
                    _caro++;
                }
                Console.WriteLine("CLASSIFICACAO: {0}", classificacao);
                impostoTOTAL = imposto + impostoTOTAL;

                Console.WriteLine("Deseja adicionar um novo produto? S/N");
                continua = Console.ReadLine();
            }
            Console.WriteLine("O VALOR TOTAL DE IMPOSTO EH {0}", impostoTOTAL);
            mediaIMPOSTO = impostoTOTAL / QUANTIDADE;
            Console.WriteLine("A MEDIA DE IMPOSTO EH: {0}", mediaIMPOSTO);
            mediaCUSTOESTOCAGEM = custoESTOQUETOTAL / QUANTIDADE;
            Console.WriteLine("O TOTAL DE VALOR NO ESTOQUE FOI: {0}", custoESTOQUETOTAL);
            Console.WriteLine("A MEDIA DOS CUSTOS DE ESTOCAGEM EH: {0}", mediaCUSTOESTOCAGEM);
            Console.WriteLine("O MENOR PRECO FINAL EH: {0} E O MAIOR EH: {1}", menorValorTOTAL, maiorValorTOTAL);
            Console.WriteLine("ITEMS PRECO BARATO: {0} ITEMS PRECO NORMAL: {1}, ITEMS PRECO CARO: {2}", _barato, _normal, _caro);
            Console.ReadKey();
        }
    }
}
