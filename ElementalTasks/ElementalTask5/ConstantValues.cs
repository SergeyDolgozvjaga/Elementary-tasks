
namespace ElementalTask5
{
    public class ConstantValues
    {
        public static readonly string[] UNITS = { "", "од", "дв", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        public static readonly string[] DECIMALS = { "", "десять ", "двадцать ", "тридцать ", "сорок ", "пятьдесят ", "шестьдесят ", "семьдесят ", "восемьдесят ", "девяносто " };
        public static readonly string[] HUNDREDS = { "", "сто ", "двести ", "триста ", "четыреста ", "пятьсот ", "шестьсот ", "семьсот ", "восемьсот ", "девятьсот " };

        public static readonly string[] NUMBERS10TO19 = {"десять ", "одинадцать ", "двенадцать ", "тринадцать ", "четырнадцать ", "пятнадцать ",
            "шестнадцать ", "семнадцать ", "восемнадцать ", "девятнадцать "};

        public static readonly string[] THOUSANS_TO_TRILLIONS_EMPTY = { "", "", "", "", "" };
        public static readonly string[] THOUSANS_TO_TRILLIONS_OV = { "триллионов ", "миллиардов ", "миллионов ", "тысяч ", "" };
        public static readonly string[] THOUSANS_TO_TRILLIONS_ON = { "триллион ", "миллиард ", "миллион ", "тысяча ", "" };
        public static readonly string[] THOUSANS_TO_TRILLIONS_ONA = { "триллиона ", "миллиарда ", "миллиона ", "тысячи ", "" };
        public static readonly string[] THOUSANS_TO_TRILLIONS_OVV = { "триллионов ", "миллиардов ", "миллионов ", "тысяч ", "" };
      
        public static readonly long MAX_VALUE = 999999999999999L;
        public static readonly long TRILLION = 1000000000000L;
        public static readonly long BILLION = 1000000000L;
        public static readonly long MILLION = 1000000L;
    }
}
