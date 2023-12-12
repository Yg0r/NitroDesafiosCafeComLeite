namespace Espelho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Valor;

            while ((int.TryParse(Console.ReadLine(), out Valor)))
            {
                if (Valor == 0)
                {
                    Environment.Exit(0);
                }
                Console.WriteLine(Valor * -1);
            }
        }
    }
}