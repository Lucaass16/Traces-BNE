public class FirstFuture
{
    public static void CalculateFirstFuture()
    {
        double valorPresente, taxaJuros, future;
        int periodoMes;

        valorPresente = 1000;
        taxaJuros = 5.3;
        periodoMes = 6;

        future = Future.CalculateCompoundInterest(valorPresente, taxaJuros, periodoMes);

        Console.WriteLine($"O valor final é de: R$ {future.ToString("F2")}");

    }
}