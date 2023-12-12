namespace InverterASequencia
{
    internal class Program
    {
        #pragma warning disable CS8602 // Dereference of a possibly null reference.

        static void Main(string[] args)
        {
            //A lógica está a mesma da InverterASequenciaCPP mas por algum motivo não rodava na plataforma, talvez pela versão do dotnet la, nem executava
            //Mas o resultado desse programa é igual ao InverterASequenciaCPP.

            _ = int.TryParse(Console.ReadLine(), out int Qtd);

            if (Qtd < 1 || Qtd > 40)
                Environment.Exit(0);

            int[] ArrayNormal = Console.ReadLine().Split(" ").Select(a => int.Parse(a)).ToArray();

            int[] Arrayinvertido = new int[ArrayNormal.Length];
 
            for (int i = 0; i < ArrayNormal.Length; i++)
            {
                Arrayinvertido[i] = ArrayNormal[ArrayNormal.Length - 1 - i];
            }

            for (int i = 0; i < Arrayinvertido.Length; i++)
            {
                Console.Write($"{Arrayinvertido[i]}");
                if (i != Arrayinvertido.Length - 1)
                    Console.Write(" ");
            }

            /*
            Pode ser feito também usando como a saída um string e um único "Console.WriteLine"
                string resul = string.Join(' ', Arrayinvertido);
                Console.WriteLine(resul);
            */
        }
    }
}