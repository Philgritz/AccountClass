using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {
    public class Checking {

        private Account _account = null;

        public bool Deposit(decimal amount) {  //must code in methods when using composition
            return _account.Deposit(amount);
        }
        public bool Withdraw(decimal amount) {
            return _account.Withdraw(amount);
        }
        public decimal GetBalance() {
            return _account.GetBalance();
        }
      
        public string Print() {
            return _account.Print();
        }

        public Checking(string description, Customer customer) {
            _account = new Account(description, customer);     //must call account constructor because not inherited

        }
            
    }
}
