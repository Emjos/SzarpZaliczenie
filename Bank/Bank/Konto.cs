using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
  
    class Konto
    {
        public delegate Boolean MyDelegate(double p);
       

        public int accNumber;
        public string ownerName;
        public double balance;
        static double staticBalance;
        public  Boolean MetodaWyplaty(double ammount)
        {
            return ammount < balance;
        }
        public Boolean MetodaWplaty(double ammount)
        {
            return ammount > 0;
        }


        public Konto(int accNumber, string ownerName, double balance)
        {
            this.accNumber = accNumber;
            this.ownerName = ownerName;
            this.balance = balance;
        }


        public Boolean payment(double amount)
        {
            MyDelegate m = new MyDelegate(MetodaWplaty);
            try
            {
                if (MetodaWplaty(amount))
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
        public void withdraw(double amount)
        {

            

            if (withdrawMethod(amount))
            {
                Console.WriteLine("Wyplata udana. Nowy stan konta nr." + accNumber + " : " + balance);
            }
         
        }

        public Boolean withdrawMethod(double amount)
        {
            MyDelegate m = new MyDelegate(MetodaWyplaty);
            try
            {


                if (!m(amount))
                {
                    Console.WriteLine("Brak srodkow na Koncie Stan " + balance);
                    Console.WriteLine("Chcesz wyplacic " + amount);
                }
                else
                {
                    balance = balance - amount;
                   
                }
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine("Wrong type of ammount");
                return false;
            }
            return m(amount);
        }

       public void printInfo()
        {
            Console.WriteLine("Numer Konta " + accNumber);
            Console.WriteLine("Wlasciciel  " + ownerName);
            Console.WriteLine("Saldo  " +balance);
            
        }
    }
}
