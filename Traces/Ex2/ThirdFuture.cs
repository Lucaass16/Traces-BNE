public class ThirdFuture
{
    public static void CalculateThirdFuture()
    {
        double presentValue, yearlyRate, future;
        int periodInYears;

        Console.Write("Digite o valor inicial para investir: ");
        presentValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de juros anual: ");
        yearlyRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o periodo em anos: ");
        periodInYears = Convert.ToInt32(Console.ReadLine());

        future = Future.CalculateCompoundInterest(presentValue, yearlyRate, periodInYears);

        Console.WriteLine($"O valor final é de: R$ {future:f2}");
    }
}