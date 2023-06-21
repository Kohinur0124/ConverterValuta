namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Convert uzs = new Convert(100000, Enums.UZS);
            Console.WriteLine();

            Convert usd = new Convert(100, Enums.USD);
            Console.WriteLine();

            Convert eur = new Convert(100, Enums.EUR);
            Console.WriteLine();

            Convert rub = new Convert(100000, Enums.RUB);
            Console.WriteLine();

        }
    }
}