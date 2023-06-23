using System;
using System.Text;

namespace Module17
{
    class Program
    {
        static void Main(string[] args)
        {
            ICount countBasicAccount = new BasicAccount();
            ICount countSalaryAccount = new SalaryAccount();

            Calculator calculatorBasic = new Calculator(countBasicAccount);
            Calculator calculatorSalary = new Calculator(countSalaryAccount);

            calculatorBasic.balance = 25480;
            calculatorBasic.Calculate();

            calculatorSalary.balance = 224856;
            calculatorSalary.Calculate();

        }
    }
}