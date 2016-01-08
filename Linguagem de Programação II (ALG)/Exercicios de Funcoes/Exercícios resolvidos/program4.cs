static void Main(string[] args)
{
	decimal preco, r;
	int reajuste;
	Console.Write("Digite um valor para o preço: ");
	 preco = Convert.ToDecimal(Console.ReadLine());
	Console.Write("Digite um valor para o reajuste: ");
	 reajuste = Convert.ToInt16(Console.ReadLine());
	 r = precoFinal(preco, reajuste);
	Console.WriteLine("Valor do preço com o reajusta: {0:c} ", r);
	Console.WriteLine("Reajuste: {0}", reajuste);
	Console.ReadKey();
}
static decimal precoFinal(decimal preco, int reajuste)
{
	decimal r;
	 r = (preco * r) / 100 + preco;
	return r;
}