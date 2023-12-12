namespace PotenciaDeDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _ = int.TryParse(Console.ReadLine(), out int Numero);
            
            if (Numero < 2 || Numero > 30)
                Environment.Exit(0);

            int result = 2;

            for (int i = 1; i < Numero; i++)
            {
                result *= 2;
            }
            Console.WriteLine(result);
        }
    }
}