static void Main(string[] args)
{
	int ano, r;
	Console.WriteLine("Escreva um ano para verificar:");
	ano = Convert.ToInt16(Console.ReadLine());
	r = bissexto(ano);
	if (r == 0) {
		Console.WriteLine("[{0}] - NÃO É BISSEXTO", r);
	}
	else {
		Console.WriteLine("[{0}] - É BISSEXTO", r);
	}
	Console.ReadKey();
}
static int bissexto(int ano)
{
	int r;
	if ((ano % 400==0) || (ano % 4 == 0) && (ano % 100 != 0)){
		r = 1;
	}
	else {
		r = 0;
	}
	return r;
}