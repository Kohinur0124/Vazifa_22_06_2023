using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa_22_06_2023
{
    public abstract class Card <T>
    {
        public abstract int Number { get; set; }

        public abstract string HolderName { get; set; }

        public abstract int Money { get; set; }

        public Card(int number,string holderName,int money)
        {
            Number = number;
            HolderName = holderName;
            Money = money;
            
        }

        public abstract int bonus { get; set; }

        public abstract T Pay(int cost);

        public abstract int Add(int amount);

        public abstract int AddWithBonus(int amount);
    }
}
