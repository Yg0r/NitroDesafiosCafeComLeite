namespace Reajuste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _ = decimal.TryParse(Console.ReadLine(), out var Salario);

            decimal Porcentagem = GetPercentual(Salario);

            decimal Reajuste = Salario * (Porcentagem / 100);
            decimal SalarioComReajuste = Salario += Reajuste;

            Console.WriteLine($"Novo salario: {decimal.Round(SalarioComReajuste, 2)}");
            Console.WriteLine($"Reajuste ganho: {decimal.Round(Reajuste, 2)}");
            Console.WriteLine($"Em percentual: {Porcentagem} %");

        }
        static decimal GetPercentual(decimal salario)
        {
            if (salario > 0 && salario <= 400)
                return 15;
            if (salario > 400 && salario <= 800)
                return 12;
            if (salario > 800 && salario <= 1200)
                return 10;
            if (salario > 1200 && salario <= 2000)
                return 7;
            if (salario > 2000)
                return 4;

            return 1;
        }
    }
}