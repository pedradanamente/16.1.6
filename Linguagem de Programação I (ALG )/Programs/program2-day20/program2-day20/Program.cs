using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            int valor1, valor2;
            double result;
            string operacao, continua;
            bool erro;

            continua = "1";
            while (continua == "1") {
                valor1 = 0;
                valor2 = 0;
                result = 0;
                erro = false;
                Console.WriteLine("Digite o primeiro número:");
                valor1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                valor2 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Digite o código da operação: + - / *");
                operacao = Console.ReadLine();
                switch (operacao) {
                    case "+":
                        result = valor1 + valor2;
                        break;
                    case "-":
                        result = valor1 - valor2;
                        break;
                    case "/":
                        if (valor2 != 0) {
                            result = valor1 / valor2;
                        } else {
                            erro = true;
                        }
                        
                        break;
                    case "*":
                        result = valor1 * valor2;
                        break;
                    default:
                        Console.WriteLine("Parâmetro Inválido!");
                        break;
                }
                if (erro == false) {
                    Console.WriteLine("O valor final da operação é: {0}", result);

                } else {
                    Console.WriteLine("Divisão não pode ser feita por zero!");
                }
                    Console.WriteLine("Deseja continuar (1) ou sair (0)?");
                    continua = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
