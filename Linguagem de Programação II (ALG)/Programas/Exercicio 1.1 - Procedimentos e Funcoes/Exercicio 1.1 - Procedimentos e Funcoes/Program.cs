using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args) {
            cadastro();
            Console.ReadKey();
        }
        static void cadastro() {
            int idade;
            string nome;
            double peso, altura;
            Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade:");
            idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Informe seu peso:");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe sua altura:");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Concluido com sucesso!");
        }
    }
}
