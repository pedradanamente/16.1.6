﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args) {
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
            mostraDados(nome,idade,peso,altura);
            Console.ReadKey();
        }
        static void mostraDados(string nome, int idade, double peso, double altura) {
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Idade: {0}", idade);
            Console.WriteLine("Peso: {0}", peso);
            Console.WriteLine("Altura: {0}", altura);
        }
    }
}
