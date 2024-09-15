public class FifthFuture
{
    public static void CalculateFifthFuture()
    {
        // vp = vf / (1 + i) ^ t

        double presentValue, yearlyRate, future, adjustedRate;
        int periodInYears;
        Console.Write("Digite o valor da taxa: ");
        yearlyRate = Convert.ToDouble(Console.ReadLine());

        future = 7390.61;
        periodInYears = 2;
        adjustedRate = 1 + Future.CalculateRate(yearlyRate);
        presentValue = future / Math.Pow(adjustedRate, periodInYears);

        Console.WriteLine($"O valor inicial foi de: R$ {presentValue:f2}{Environment.NewLine}"
                            +$"Para chegar ao resultado final: {future}");
    }
}