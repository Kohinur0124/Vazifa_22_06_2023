using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa_22_06_2023
{
    public class Humo : Card<int>
    {
        public Humo(int number, string holderName, int money) : base(number, holderName, money)
        {
        }

        public override int Number { get; set ; }
        public override string HolderName { get ; set ; }
        public override int Money { get ; set ; }
        public override int bonus { get; set; } = 5;

        public override int Add(int amount)
        {
            Money += amount;
            return Money;
        }

        public override int AddWithBonus(int amount)
        {
            Money += bonus +amount;
            return Money;
        }

        public override int Pay(int cost)
        {
            Money -= cost;
            return Money;
        }

        public bool PayWireless (int cost)
        {
            if (cost > 50000 && Money - cost < 0)
            {
                return false;
            }
            return true;
        }
    }
}
