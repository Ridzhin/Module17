using System;
using System.Text;

namespace Module17
{
    public class SalaryAccount : ICount
    {
        public void CalculateInterest(double balance)
        {
            double interest = balance * 0.5;

            Console.WriteLine($"Расчет процентной ставки зарплатного аккаунту: {interest}");
        }
    }
}