using static System.Runtime.InteropServices.JavaScript.JSType;

public class FourthFuture
{
    public static void CalculateFourthFuture()
    {
        double presentValue, monthlyRate, adjustedRate;
        int periodInMonths, withdrawMonth;

        presentValue = 2000;
        monthlyRate = 2;
        adjustedRate = Future.CalculateRate(monthlyRate);
        periodInMonths = 6;
        withdrawMonth = 5;

        WriteFutureByMonthWithWithdraw(presentValue, monthlyRate, periodInMonths, withdrawMonth, 1000);

    }

    private static void WriteFutureByMonthWithWithdraw(double presentValue, double rate, int period, int withdrawMonth, double withdrawAmount)
    {
        double accumulated, profit, netProfit, withdraw;
        accumulated = presentValue;

        Console.WriteLine("Mes\t\t Taxa de Juros\t Rendimento\t Saque\t\t Rendimento Liquido\t Renda total");
        for (int i = 1; i <= period; i++)
        {
            withdraw = 0;
            profit = Future.CalculateCompoundInterest(presentValue, rate, i);

            if (i == withdrawMonth)
            {
                profit -= withdrawAmount;
                netProfit = profit - presentValue;
                accumulated += netProfit;
                withdraw = withdrawAmount;
            }

            else
            {
                netProfit = profit - presentValue;
                accumulated += netProfit;

            }
            Console.WriteLine($"{i}\t\t {rate}%\t\t R$ {profit:F2}\t R$ {withdraw}\t\t R$ {netProfit:F2}\t\t R$ {accumulated:F2}");

        }
    }
}