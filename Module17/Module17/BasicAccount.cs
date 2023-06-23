using System;
using System.Text;

namespace Module17
{
    public class BasicAccount : ICount
    {
        public void CalculateInterest(double balance)
        {
            double interest = balance * 0.4;

            if (balance < 10000)
            {
                interest -= balance * 0.2;
            }

            if (balance < 25000)
            {
                interest -= balance * 0.4;
            }

            Console.WriteLine($"Расчет процентной базового аккаунта: {interest}");
        }
    }
}