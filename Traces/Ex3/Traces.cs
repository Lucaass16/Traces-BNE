namespace TracesEx3
{
    class Traces
    {
        public static void CalculateFirstTrace()
        {
            var investment = new Investment();

            investment.WriteCompoundInterest();
        }

        public static void CalculateSecondTrace()
        {
            var invest = new Investment();
            Console.Write("Qual mes deseja sacar?: ");
            int withdrawMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual a quantidade do saque?: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());

            invest.WriteCompoundInterest(withdrawMonth, withdrawAmount);

        }
    }
}
