using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
  
    class Konto
    {
        public delegate Boolean MyDelegate(double p);
       

        int accNumber;
        string ownerName;
        double balance;
        static double staticBalance;
        public  Boolean Metoda(double ammount)
        {
            return ammount < balance;
        }

        public Konto(int accNumber, string ownerName, double balance)
        {
            this.accNumber = accNumber;
            this.ownerName = ownerName;
            this.balance = balance;
        }

        public Boolean payment(double amount)
        {
            try
            {
                if (amount > 0)
                {
                    balance = balance + amount;
                    Console.WriteLine("Wplata udana. Nowy stan konta to : " + balance);
                    return true;
                }
                return false;
            }
            catch(ArrayTypeMismatchException e)
            {
                Console.WriteLine("Wrong type of ammount");
                return false;
            }
        }   
        public Boolean withdraw(double amount)
        {
            MyDelegate m = new MyDelegate(Metoda);
            try
            {


                if (m(amount) == false)
                {
                    Console.WriteLine("Brak srodkow na Koncie Stan " + balance);
                    Console.WriteLine("Chcesz wyplacic " + amount);
                }
                else
                {
                    balance = balance - amount;
                    Console.WriteLine("Wyplata udana. Nowy stan konta nr." + accNumber + " : " + balance);
                }
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine("Wrong type of ammount");
                return false;
            }
            return m(amount);
        }

        public Boolean transfer(Konto konto,double amount)
        {
            if (withdraw(amount) == true)
            {
                konto.balance = konto.balance + amount;
                Console.WriteLine("Przelew na konto " + konto.accNumber +" zostalo zrealizowane");
                Console.WriteLine("Nowy stan konta na ktore przelano to " + konto.balance);
            }

           return withdraw(amount);
            
        }

       public void printInfo()
        {
            Console.WriteLine("Numer Konta " + accNumber);
            Console.WriteLine("Wlasciciel  " + ownerName);
            Console.WriteLine("Saldo  " +balance);
            
        }
    }
}
