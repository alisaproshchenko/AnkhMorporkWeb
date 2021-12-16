namespace Web.Player
{
    public class Player
    {
        public static decimal Money { get; private set; } = 100.0m;
        public static int Beer { get; private set; } = 0;

        public static void Restart()
        {
            Money = 100.0m;
            Beer = 0;
        }
        public static void GainMoney(decimal income)
        {
            Money += income;
        }

        public static void SpendMoney(decimal expenditure)
        {
            Money -= expenditure;
        }

        public static void BuyBeer()
        {
            Money -= 2;
            Beer++;
        }

        public static void SpendBeer()
        {
            Beer--;
        }
    }
}