namespace AMelhorCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada = Console.ReadLine().Split(" ");

            char.TryParse(Entrada[0], out char Calcular);
            double.TryParse(Entrada[1], out double Numero1);
            double.TryParse(Entrada[2], out double Numero2);

            switch (Calcular)
            {
                case '+':
                    Console.WriteLine(Math.Round(Numero1 + Numero2, 1));
                    break;
                case '-':
                    Console.WriteLine(Math.Round(Numero1 - Numero2, 1));
                    break;
                case '/':
                    Console.WriteLine(Math.Round(Numero1 / Numero2, 1));
                    break;
                case '*':
                    Console.WriteLine(Math.Round(Numero1 * Numero2, 1));
                    break;
            }
        }
    }
}