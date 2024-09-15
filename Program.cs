using System.Diagnostics;

class Program
{
    static void Main()
    {
        int menuChoice;
        string continueInSystem;

        while (true)
        {
            Console.Clear();

            Console.WriteLine("1) Exercicio 1 - Parte 1");
            Console.WriteLine("2) Exercicio 1 - Parte 2");
            Console.WriteLine("3) Exercicio 1 - Parte 3");
            Console.WriteLine("-------------------------");
            Console.WriteLine("4) Exercicio 2 - Parte 1");
            Console.WriteLine("5) Exercicio 2 - Parte 2");
            Console.WriteLine("6) Exercicio 2 - Parte 3");
            Console.WriteLine("7) Exercicio 2 - Parte 4");
            Console.WriteLine("8) Exercicio 2 - Parte 5");
            Console.WriteLine("-------------------------");
            Console.WriteLine("9) Exercicio 3 - Parte 1 e 3");
            Console.WriteLine("10) Exercicio 3 - Parte 2");

            Console.Write($"{Environment.NewLine}Qual teste deseja executar: ");
            menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    TracesEx1.Traces.Trace1();
                    break;
                case 2:
                    TracesEx1.Traces.Trace2();
                    break;
                case 3:
                    TracesEx1.Traces.Trace3();
                    break;
                case 4:
                    FirstFuture.CalculateFirstFuture();
                    break;
                case 5:
                    SecondFuture.CalculateSecondFuture();
                    break;
                case 6:
                    ThirdFuture.CalculateThirdFuture();
                    break;
                case 7:
                    FourthFuture.CalculateFourthFuture();
                    break;
                case 8:
                    FifthFuture.CalculateFifthFuture();
                    break;
                case 9:
                    TracesEx3.Traces.CalculateFirstTrace();
                    break;
                case 10:
                    TracesEx3.Traces.CalculateSecondTrace();
                    break;
                default:
                    Console.WriteLine("Teste não encontrado");
                    break;
            }

            Console.WriteLine("-------------------------");

            Console.Write("Deseja continuar?(S/N): ");
            continueInSystem = Console.ReadLine().ToUpper();

            if (continueInSystem == "N")
            {
                break;
            }
        }

    }
}