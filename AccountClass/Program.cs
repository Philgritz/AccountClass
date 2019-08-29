using System;

namespace AccountClass {
    class Program {
        static void Main(string[] args) {
            var cust1 = new Customer();   //use default constructor
            cust1.Name = "New Customer"; //creates new Customer
            
            var acct1 = new Account("Primary Checking", cust1);
            acct1.Deposit(2);
          

            var acct2 = new Account("Secondary Checking", cust1); //passthrough customer 1 to constructor
            acct2.Deposit(1000);

            cust1.Name = "1st Customer";  // change customer name 

            var acct3 = new Account("Primary Savings", cust1);
            acct3.Deposit(50000);
           

            var accounts = new Account[] { acct1, acct2, acct3 };   //create an array of accounts. collection of account instances
            var accountTotal = 0M;
            foreach (var account in accounts) {  //copy acct1, process, copy acct2 proceses...
                accountTotal += account.GetBalance();   //gets account balance, adds to total
                Console.WriteLine($"{account.AccountNumber} {account.Description} "
                + $"{account.GetBalance()} {account.CustomerInstance.Name}");
            }
            Console.WriteLine($"Total of all account is {accountTotal}");
        }

    }
}
