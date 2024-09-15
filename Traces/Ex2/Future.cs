public class Future
{

    public static double CalculateSimpleInterest(double presentValue, double rate, int period)
    {
        double Future, adjustedRate;
        adjustedRate = CalculateRate(rate);
        Future = period * (1 + (adjustedRate * period));

        return Future;
    }

    public static double CalculateCompoundInterest(double presentValue, double rate, int period)
    {
        double Future, adjustedRate;
        adjustedRate = 1 + CalculateRate(rate);
        Future = presentValue * Math.Pow(adjustedRate, period);

        return Future;
    }

    public static double CalculateRate(double rate)
    {
        return rate / 100;
    }

}