namespace HoraDeSaltar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Entradas = Console.ReadLine().Split(" ");

            int DistanciaASerPercorrida = int.Parse(Entradas[0]);
            decimal DistanciaCadaSalto = decimal.Parse(Entradas[1]);

            decimal SaltosNecessarios = DistanciaASerPercorrida / DistanciaCadaSalto;
            
            Console.WriteLine(Math.Ceiling(SaltosNecessarios));
        }
    }
}