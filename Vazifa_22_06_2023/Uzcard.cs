using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa_22_06_2023
{
    public class Uzcard : Card<bool>
    {
        public Uzcard(int number, string holderName, int money) : base(number, holderName, money)
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
            Money += amount+bonus;
            return Money;
        }

        public override bool Pay(int cost)
        {
            if(Money-cost < 0) return false;
            else
            {
                Money -= cost;
                return true;
            }
        }
        
    }
}
