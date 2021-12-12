using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Player
{
    public class Player
    {
        //public string Name { get; }
        public static double Money { get; private set; }
        public UnitOfWork Uow;
        public static bool IsDead { get; private set; }
        public Player()
        {
            Money = 100.0;
            IsDead = false;
        }
        public static void GainMoney(double income)
        {
            Money += income;
        }

        public static void SpendMoney(double expenditure)
        {
            Money -= expenditure;
        }

        public static void Die()
        {
            IsDead = true;
        }
    }
}