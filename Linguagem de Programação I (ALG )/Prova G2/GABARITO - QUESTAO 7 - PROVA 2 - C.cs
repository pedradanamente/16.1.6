//ADAPTADO DE GUILHERME ROSSATO
static void Main(string[] args)
        {

            int tamanhoXGgolaV = 0, totalTamanhoPcorA = 0, totalInformado = 0, golaRprecoMenor40 = 0, totalP = 0, totalM = 0, totalG = 0, totalXG = 0, totalBranca = 0;
            decimal preco, precoMaisAltoG = 0, precosTamanhoPcorA = 0;
            char cor, gola;
            string tamanho, maiorNr = "";
            Console.WriteLine("-------------------");
            Console.WriteLine("Preço: (Digite 0 para encerrar)");
            Console.Write("=> R$");
            preco = Convert.ToDecimal(Console.ReadLine());
            while (preco != 0)
            {
                Console.Clear();
                Console.SetCursorPosition(15, 0);
                Console.WriteLine("-------------------");
                Console.SetCursorPosition(15, 1);
                Console.WriteLine("CONTROLE DE ESTOQUE");
                Console.SetCursorPosition(15, 2);
                Console.WriteLine("-------------------");
                Console.WriteLine("Informe os seguintes dados");
                do
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Tamanho: P / M / G / XG");
                    Console.Write("=> ");
                    tamanho = Convert.ToString(Console.ReadLine());
                    if ((tamanho != "P") && (tamanho != "M") && (tamanho != "G") && (tamanho != "XG"))
                    {
                        Console.WriteLine("Entrada Inválida");                        
                    }
                } while ((tamanho != "P") && (tamanho != "M") && (tamanho != "G") && (tamanho != "XG"));
                do
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Cor: B (Branca) / A (Azul) / L (Laranja)");
                    Console.Write("=> ");
                    cor = Convert.ToChar(Console.ReadLine());
                    if ((cor != 'B') && (cor != 'A') && (cor != 'L'))
                    {
                        Console.WriteLine("Entrada Inválida");
                    }
                } while ((cor != 'B') && (cor != 'A') && (cor != 'L'));
                do
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Gola: R (Redonda) / V ");
                    Console.Write("=> ");
                    gola = Convert.ToChar(Console.ReadLine());
                    if ((gola != 'R') && (gola != 'V'))
                    {
                        Console.WriteLine("Entrada Inválida");
                    }
                } while ((gola != 'R') && (gola != 'V'));
                totalInformado = totalInformado + 1;
                if ((tamanho == "XG") && (gola == 'V'))
                {
                    tamanhoXGgolaV = tamanhoXGgolaV + 1;
                }
                if (tamanho == "P")
                {
                    totalP = totalP + 1;
                }
                else if (tamanho == "M")
                {
                    totalM = totalM + 1;
                }
                else if (tamanho == "G")
                {
                    totalG = totalG + 1;
                    if (preco > precoMaisAltoG)
                    {
                        precoMaisAltoG = preco;
                    }
                }
                else if (tamanho == "XG")
                {
                    totalXG = totalXG + 1;
                }

                if ((tamanho == "P") && (cor == 'A'))
                {
                    totalTamanhoPcorA = totalTamanhoPcorA + 1;
                    precosTamanhoPcorA = precosTamanhoPcorA + preco;
                }

                if ((gola == 'R') && (preco < 40) && (preco > 0))
                {
                    golaRprecoMenor40 = golaRprecoMenor40 + 1;
                }
                if (cor == 'B')
                {
                    totalBranca = totalBranca + 1;
                }
            }
            if (tamanhoXGgolaV > 0)
            {
                Console.WriteLine("Camisetas que possuem tamanho XG e gola em V: " + tamanhoXGgolaV);
            }
            else
            {
                Console.WriteLine("Não há camisetas que possuam tamanho XG e gola em V.");
            }

            if (precoMaisAltoG > 0)
            {
                Console.WriteLine("Preço mais alto dentre as camisetas que possuem tamanho G: " + precoMaisAltoG);
            }
            else
            {
                Console.WriteLine("Não há camisetas com tamanho G.");
            }

            if (precosTamanhoPcorA > 0)
            {
                Console.WriteLine("A média de preço das camisetas que possuem tamanho P e cor Azul: {0:C}", precosTamanhoPcorA / totalTamanhoPcorA);
            }
            else
            {
                Console.WriteLine("Não há camisetas que possuam tamanho P e cor Azul.");
            }
            if (golaRprecoMenor40 > 0)
            {
                Console.WriteLine("Total camisetas com gola Redonda e preço menor que R$40,00: " + golaRprecoMenor40);
            }
            else
            {
                Console.WriteLine("Não há camisetas que possuam gola Redonda e preço menor que R$40,00.");
            }
            if (totalInformado > 0)
            {
                if ((totalP > totalM) && (totalP > totalG) && (totalP > totalXG))
                {
                    maiorNr = "P";
                }
                else if ((totalM > totalP) && (totalM > totalG) && (totalM > totalXG))
                {
                    maiorNr = "M";
                }
                else if ((totalG > totalP) && (totalG > totalM) && (totalG > totalXG))
                {
                    maiorNr = "G";
                }
                else if ((totalXG > totalP) && (totalXG > totalM) && (totalXG > totalG))
                {
                    maiorNr = "XG";
                }
                Console.WriteLine("O tamanho que possui o maior número de camisetas é: " + maiorNr);
            }
            if (totalBranca > 0)
            {
                Console.WriteLine("O percentual de camisetas, em relação ao total, que possuem cor Branca é: " + ((double)(totalBranca * 100) / totalInformado) + "%");
            }
            else
            {
                Console.WriteLine("Não há camisetas brancas.");
            }
            Console.ReadKey();
        }
