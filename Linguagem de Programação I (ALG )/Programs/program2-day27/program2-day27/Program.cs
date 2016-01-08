using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            /*Escrever um programa que receba como entrada o destino de 50 passageiros (conforme tabela abaixo) e se
a viagem inclui retorno (ida e volta). O programa deve calcular e informar o preço da passagem a ser
adquirida (de cada passageiro)(Adaptado de Lopes & Garcia, 2002):*/
            string destino, retorno;
            int i;
            double valor;

            for (i = 1; i <= 50; i++) {
                valor = 0;
                Console.WriteLine("[{0}] Digite seu destino: norte/nordeste/centro-oeste/sul",i);
                destino = Console.ReadLine();
                Console.WriteLine("IDA: 1, IDA E VOLTA: 2");
                retorno = Console.ReadLine();
                switch (destino) {
                    case "norte":
                        valor = 500.00;
                        if (retorno == "2") {
                            valor = valor + 400.00;
                        }
                        break;
                    case "nordeste":
                        valor = 350.00;
                        if (retorno == "2") {
                            valor = valor + 300.00;
                        }
                        break;
                    case "centro-oeste":
                        valor = 350.00;
                        if (retorno == "2") {
                            valor = valor + 250.00;
                        }
                        break;
                    case "sul":
                        valor = 300.00;
                        if (retorno == "2") {
                            valor = valor + 250.00;
                        }
                        break;
                    default:
                        valor = 0;
                        Console.WriteLine("Parâmetro inválido!");
                        break;
                }
                Console.WriteLine("Valor da passagem: {0:C}", valor);
                Console.WriteLine("Pressione uma tecla para continuar.");
                Console.ReadKey();
            }
        }
    }
}
