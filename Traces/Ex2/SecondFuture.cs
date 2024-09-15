public class SecondFuture
{
    public static void CalculateSecondFuture()
    {
        double valorPresente, taxaJuros;
        int periodoMes;

        valorPresente = 3800.0;
        taxaJuros = 1.25;
        periodoMes = 6;

        WriteFutureByMonth(valorPresente, taxaJuros, periodoMes);
    }

    private static void WriteFutureByMonth(double presentValue, double rate, int period)
    {
        double accumulated, profit, netProfit;
        accumulated = presentValue;

        Console.WriteLine("Mês\t Taxa de Juros\t Rendimento\t Rendimento Liquido\t Renda total");

        for (int i = 1; i <= period; i++)
        {
            profit = Future.CalculateCompoundInterest(presentValue, rate, i);
            netProfit = profit - presentValue;
            accumulated += netProfit;
            
            Console.WriteLine($"{i}\t\t {rate:F2}%\t R${profit:F2}\t\t R${netProfit:F2}\t R${accumulated:F2}");
        }
    }
}