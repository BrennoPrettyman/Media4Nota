namespace Media4Nota;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        String Situação;
        Double nota1, nota2, nota3, nota4;

        Console.WriteLine("---- MÉDIA ARITMÉTICA ----");
        Console.WriteLine();
        Console.WriteLine("DIGITE SUAS NOTAS ABAIXO: ");
        Console.WriteLine();

        Console.WriteLine("NOTA 1: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("NOTA 2: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("NOTA 3: ");
        nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("NOTA 4: ");
        nota4 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();

        Console.Clear();


        //Tranquilo por aqui

        if (nota1 < 0 || nota1 > 10 ||
        nota2 < 0 || nota2 > 10 ||
        nota3 < 0 || nota3 > 10 ||
        nota4 < 0 || nota4 > 10)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ESCREVA UM NÚMERO DE 0 A 10");
            Console.ResetColor();
        }


        else
        {

            double total;
            total = nota1 + nota2 + nota3 + nota4;

            double media;
            media = total / 4;

            if (media < 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Situação = "Reprovado";
                Console.ResetColor();
            }

            else if (media < 6)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Situação = "Recuperação";
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Situação = "Aprovado";
                Console.ResetColor();
            }

            Console.WriteLine($"A Média do aluno é {media}");
            Console.WriteLine($"Portanto a situação do aluno é {Situação}");

        }

        Console.WriteLine();

        Console.WriteLine("Clique para Continuar... ");
        Console.ReadKey();

        Console.Clear();

    }
}
