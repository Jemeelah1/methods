using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 10000.00;
            WemaPensioneers customers = new WemaPensioneers();
            customers.Registration();
            customers.CheckBalance( amount);
            customers.Deposit(amount);
            customers.Redrawal(amount);

        }
    }

    class WemaPensioneers
    {
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public string Organization { get; set; }



        public void Registration()
        {
            //return numberofRegistration
            Console.WriteLine("Please enter your fullname ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Please enter your Gender");
            Gender = Console.ReadLine();
            Console.WriteLine("Please enter organization");
            Organization = Console.ReadLine();

            
        }


          public void CheckBalance(double amount)
        {
            Console.WriteLine("this is the amount " + amount);
            
        }
          

         public void Deposit(double amount)
        {
            Console.WriteLine("Please enter amount you want to deposit");
            var amountdeposited = Convert.ToDouble(Console.ReadLine());
            amount += amountdeposited;
            Console.WriteLine("your deposit is " + amount);
        }


         public void Redrawal(double amount)
        {
            Console.WriteLine("Please enter amount you want to Redraw");
            var amountredraw = Convert.ToDouble(Console.ReadLine());
            amount -= amountredraw;
            Console.WriteLine("your balance after withdrawal is " + amount);
        }
    }


}     
     
