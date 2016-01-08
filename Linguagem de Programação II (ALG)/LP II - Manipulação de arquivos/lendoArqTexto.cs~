/*Lendo de um arquivo texto*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace testeArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto;
            if (File.Exists("c:\\teste.txt"))
            {
                StreamReader rd = new StreamReader("c:\\teste.txt");            
                texto = rd.ReadToEnd();
                Console.WriteLine(texto);
                rd.Close();
            }
            else
                Console.WriteLine("Arquivo não encontrado!");
            Console.ReadKey();
        }
    }
}

