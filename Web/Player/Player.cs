using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Player
{
    public class Player
    {
        public static double Money { get; private set; } = 100.0;
        public static int Beer { get; private set; } = 0;

        public static void Restart()
        {
            Money = 100.0;
            Beer = 0;
        }
        public static void GainMoney(double income)
        {
            Money += income;
        }

        public static void SpendMoney(double expenditure)
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