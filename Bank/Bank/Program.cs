using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto konto1 = new Konto(123, "Zdzisiek ", 1000);
            Konto konto2 = new Konto(222, "Wiesiek", 500);
            konto1.printInfo();
            konto1.payment(1000);
            konto1.withdraw(500);
            konto1.withdraw(2500);
            konto1.transfer(konto2, 500);
            konto1.printInfo();
            Console.ReadKey();
        }
    }
}
