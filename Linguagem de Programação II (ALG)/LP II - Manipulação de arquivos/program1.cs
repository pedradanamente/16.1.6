using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            string filename,nome,endereco,cidade,estado;
            int idade;
            double altura,peso;

            Console.WriteLine("Digite um nome p/ o arquivo:");
            filename = "C:\\" + Console.ReadLine() + ".txt";
            StreamWriter wr = new StreamWriter(filename);
            Console.WriteLine("Caminho definico como: {0}", filename);
            Console.WriteLine("Informe o Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a Idade:");
            idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Informe a Altura:");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o Peso:");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o Endereço:");
            endereco = Console.ReadLine();
            Console.WriteLine("Informe a Cidade:");
            cidade = Console.ReadLine();
            Console.WriteLine("Informe o Estado:");
            estado = Console.ReadLine();
            wr.WriteLine("CADASTRO DE USUÁRIO"
                + "\nNome: {0}"
                + "\nIdade: {1}"
                + "\nAltura: {2}"
                + "\nPeso: {3}"
                + "\nEndereço: {4}"
                + "\nCidade: {5}"
                + "\nEstado: {6}", nome, idade, altura, peso, endereco, cidade, estado);
            wr.Close();
            Console.WriteLine("Salvo com sucesso!");
            Console.ReadKey();
        }
    }
}
