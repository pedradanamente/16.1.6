static void Main(string[] args) {
	double celcius, f;
	Console.WriteLine("Digite a temperatura em Franks:");
	f = Convert.ToDouble(Console.ReadLine());
	celcius = convertTemp(f);
	Console.WriteLine(celcius);
	Console.ReadKey();
}
static double convertTemp(double f) {
	double r;
	r = (f - 32) / 1.8;
	return r;
}