using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Transfer
    {

        public static Boolean transfer(Konto kontoFrom, Konto kontoTo, double amount)
        {

            Boolean check = kontoFrom.withdrawMethod(amount);
            if (check) 
            {
                kontoTo.balance = kontoTo.balance + amount;
                Console.WriteLine("Przelew na konto " + kontoTo.accNumber + " zostalo zrealizowane");
                Console.WriteLine("Nowy stan konta na ktore przelano to " + kontoTo.balance);
            }

            return check;

        }

    }
}
