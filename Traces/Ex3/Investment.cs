public class Investment
{
    public double PresentValue {  get; set; }

    public double Rate {  get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public Investment()
    {
        Console.Write("Digite o valor inicial para investir: ");
        PresentValue = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a taxa que deseja: ");
        Rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a data de inicio: ");
        StartDate = DateTime.ParseExact(Console.ReadLine(), "d", null);
        Console.Write("Digite a data final: ");
        EndDate = DateTime.ParseExact(Console.ReadLine(), "d", null);

        if (EndDate < StartDate)
        {
            throw new ArgumentException("A data final não pode ser menor que a inicial!");
        }
    }

    private static double CalculateRate(double rate)
    {
        return rate / 100;
    }

    private void DisplayMonthlyData(DateTime currentDate, double accumulated, double monthlyProfit, double netProfit, double withdraw = 0)
    {
        if (withdraw == 0)
        {
            Console.WriteLine($"{currentDate.Day}/{currentDate.Month}/{currentDate.Year}\t\t {Rate}%\t\t R$ {monthlyProfit:F2}\t\t R$ {netProfit:F2}\t\t R$ {accumulated:F2}");
        }
        else
        { 
            Console.WriteLine($"{currentDate.Day}/{currentDate.Month}/{currentDate.Year}\t\t {Rate}%\t\t R$ {monthlyProfit:F2}\t R$ {withdraw}\t R$ {netProfit:F2}\t\t R$ {accumulated:F2}"); 
        }
    }

    public void WriteCompoundInterest(int withdrawMonth, double withdrawAmount)
    {
        double accumulated, dailyProfit, monthlyProfit, netProfit, dailyRate, withdraw;
        int startMonth, monthCount;
        withdraw = 0;
        monthCount = 1;
        monthlyProfit = 0;
        accumulated = PresentValue;
        startMonth = StartDate.Month;

        DateTime currentDate = StartDate.Date;

        Console.WriteLine("Data\t\t Taxa de Juros\t Rendimento Mensal\t Saque\t Rendimento Liquido\t Renda total");
        while (currentDate <= EndDate)
        {
            dailyRate = Math.Pow(1 + CalculateRate(Rate), 1.0 / 30) - 1;
            dailyProfit = accumulated * dailyRate;
            monthlyProfit += dailyProfit;
            netProfit = accumulated - PresentValue;
            accumulated += dailyProfit;

            if (currentDate.Month != startMonth || currentDate.Date == EndDate.Date)
            {
                if (monthCount == withdrawMonth)
                {
                    accumulated -= withdrawAmount;
                    withdraw = withdrawAmount;
                }
                DisplayMonthlyData(currentDate, accumulated, monthlyProfit, netProfit, withdraw);
                startMonth = currentDate.Month;
                monthlyProfit = 0;
                withdraw = 0;
                monthCount++;
            }

            currentDate = currentDate.AddDays(1);
        }
    }

    public void WriteCompoundInterest()
    {
        double accumulated, dailyProfit, monthlyProfit, netProfit, dailyRate;
        int startMonth;
        monthlyProfit = 0;
        accumulated = PresentValue;
        startMonth = StartDate.Month;

        DateTime currentDate = StartDate.Date;

        Console.WriteLine("Data\t\t Taxa de Juros\t Rendimento Mensal\t Rendimento Liquido\t Renda total");
        while (currentDate <= EndDate)
        {
            dailyRate = Math.Pow(1 + CalculateRate(Rate), 1.0 / 30) - 1;
            dailyProfit = accumulated * dailyRate;
            monthlyProfit += dailyProfit;
            netProfit = accumulated - PresentValue;
            accumulated += dailyProfit;

            if (currentDate.Month != startMonth || currentDate.Date == EndDate.Date)
            {
                DisplayMonthlyData(currentDate, accumulated, monthlyProfit, netProfit);
                startMonth = currentDate.Month;
                monthlyProfit = 0;
            }

            currentDate = currentDate.AddDays(1);
        }
    }

}