/*Abrindo um arquivo texto e incluindo conteúdo no final*/
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
            string texto;
            StreamWriter wr = new StreamWriter("c:\\teste.txt",true);           
            wr.WriteLine();
            wr.Write("Esta frase será adicionada no final do arquivo teste.txt");                                
            wr.Close();            
            
            //lendo o arquivo
            Console.WriteLine("Mostrando na tela o conteúdo do arquivo teste.txt:\n");
            StreamReader rd = new StreamReader("c:\\teste.txt");
            if (File.Exists("c:\\teste.txt"))
            {
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

