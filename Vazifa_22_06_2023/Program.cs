namespace Vazifa_22_06_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uzcard uzcard = new Uzcard(1234, "Sevinch", 100000);
            var money =uzcard.AddWithBonus(15000);
            Console.WriteLine(uzcard.Pay(100000));

            Humo humo = new Humo(234, "Sevinch1", 50000);
            Console.WriteLine(humo.PayWireless(50000));
        }
    }
}