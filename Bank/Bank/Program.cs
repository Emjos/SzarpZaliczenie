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
            konto2.printInfo();
            Console.WriteLine("----------------------------------------------");
            konto1.payment(1000);
            Console.WriteLine("----------------------------------------------");
            konto1.withdraw(500);
            Console.WriteLine("----------------------------------------------");
            konto1.withdraw(2500);
        
         Console.WriteLine("----------------------------------------------");
            Transfer.transfer(konto1,konto2,200);
            Console.WriteLine("----------------------------------------------");
            
           
            konto1.printInfo();
            konto2.printInfo();
            Console.ReadKey();
        }
    }
}
