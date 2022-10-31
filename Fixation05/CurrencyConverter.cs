namespace FixationExercises
{
    class CurrencyConverter
    {
        public static double iof = 6.00;

        public static double Converter(double quote, double currency)
        {
            double dollarQuote = quote + (quote * (iof / 100));
            double cost = currency * dollarQuote;

            return cost;
        }
    }
}
