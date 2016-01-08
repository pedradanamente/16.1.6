//ADAPTADO DE LEONARDO GIULIANI
static void Main(string[] args)
        {
            string tamanho, cor, gola;
            decimal preco, alto = 0, media = 0;
            double perc;
            int cont = 0, quant = 0, total = 0, ama = 0, ver = 0, lar = 0, camisas = 0, contV = 0;
           
            Console.WriteLine("Informe o preço da camiseta (Digite zero se quiser finalizar o programa)");
            preco = Convert.ToDecimal(Console.ReadLine());
            alto = preco;
            while (preco != 0)
            {

                camisas++;
                Console.WriteLine("Informe o tamanho da camiseta: P, M, G XG");
                tamanho = Convert.ToString(Console.ReadLine());
                while (tamanho != "P" && tamanho != "M" && tamanho != "G" && tamanho != "XG")
                {
                    Console.WriteLine("Erro! Tente novamente");
                    Console.WriteLine("Informe o tamanho da camiseta: P, M, G XG");
                    tamanho = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine("informe a cor da camiseta: A-Amarela, V-Verde, L-Laranja");
                cor = Convert.ToString(Console.ReadLine());
                while (cor != "A" && cor != "V" && cor != "L")
                {
                    Console.WriteLine("Erro! Tente novamente");
                    Console.WriteLine("Informe a cor da camiseta: A-Amarela, V-Verde, L-Laranja");
                    cor = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine("Informe a gola da camiseta: R-Redonda ou V-Em V");
                gola = Convert.ToString(Console.ReadLine());
                while (gola != "R" && gola != "V")
                {
                    Console.WriteLine("Erro! Tente novamente");
                    Console.WriteLine("Informe a gola da camiseta: R-Redonda ou V-Em V");
                    gola = Convert.ToString(Console.ReadLine()); ;
                }
                //LETRA A
                if (preco >= 30 && preco <= 40 && tamanho == "M")
                {
                    quant++;
                }
                //LETRA B
                if (gola == "R" && cor == "A")
                {
                    if (preco > alto)
                    {
                        alto = preco;
                    }
                }
                //LETRA C
                if (gola == "V" && cor == "V")
                {
                    cont++;
                    media = media + preco;
                }
                //LETRA D
                if (preco > 35 && cor == "L")
                {
                    total++;
                }
                //LETRA E
                if (cor == "A")
                {
                    ama++;
                }
                else if (cor == "V")
                {
                    ver++;
                }
                else if (cor == "L")
                {
                    lar++;
                }
                //LETRA F
                if (gola == "V")
                {
                    contV++;
                }

                Console.WriteLine("Informe o preço da camiseta (Digite zero se quiser finalizar o programa)");
                preco = Convert.ToDecimal(Console.ReadLine());
            }
            if (camisas > 0)
            {
                Console.WriteLine("A quantidade de camisetas com preço entre R$ 30,00 e R$ 40,00 e tamanho M é: " + quant);
                Console.WriteLine("O preço mais alto entre as camisetas com gola redonda e cor amarela é: " + alto);
                if (cont != 0)
                {
                    media = media / cont;
                }
                Console.WriteLine("A média de preço entre as camisetas com gola V e cor verde é: R$" + media);
                Console.WriteLine("O total de camisetas com preço maior quer R$ 35,00 e com laranja é: " + total);
                if (ama < ver && ama < lar)
                {
                    Console.WriteLine("A cor que possui menos camisa é Amarelo");
                }
                else if (ver < ama && ver < lar)
                {
                    Console.WriteLine("A cor que possui menos camisa é Verde");
                }
                else if (lar < ama && lar < ver)
                {
                    Console.WriteLine("A cor que possui menos camisa é Laranja");
                }
                else
                {
                    Console.WriteLine("Todas as cores possuem a mesma quantidade.");
                }

                perc = (double)100 * contV / camisas;
                Console.WriteLine("O percentual de camisas que possuem gola em V é:" + perc);
            }
            Console.WriteLine("Tecle algo para sair.");
            Console.ReadKey();
        }
