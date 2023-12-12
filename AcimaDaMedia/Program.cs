namespace AcimaDaMedia
{
    #pragma warning disable CS8602 // Dereference of a possibly null reference.
    #pragma warning disable CS8604 // Dereference of a possibly null reference.
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumeroAlunos = int.Parse(Console.ReadLine());

            if (NumeroAlunos < 1 || NumeroAlunos > 200)
                Environment.Exit(0);

            int[] NotasAlunos = Console.ReadLine().Split(" ", NumeroAlunos).Select(Nota => int.Parse(Nota)).ToArray();


            int SomaMedia = 0;
            int ContadorAluno = 0;

            foreach (int nota in NotasAlunos)
            {
                if (nota < 0 || nota > 100)
                    break;

                SomaMedia += nota;
            }

            int Media = SomaMedia / NumeroAlunos;

            foreach (int notaIndividual in NotasAlunos)
            {
                if (notaIndividual > Media)
                    ContadorAluno++;
            }

            Console.WriteLine(ContadorAluno);

            Console.ReadLine();
        }
    }
}