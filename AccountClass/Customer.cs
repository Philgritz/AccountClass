using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {

    public class Customer {

  
        private static int nextIdNbr = 0;   // static = only 1 for the class, all instances share it
        public int Id { get; private set; }     // 'private set' only class can set value
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Sales { get; private set; } = 0; //dont need to make a get method
        public bool Active { get; set; } = true;

        private bool CheckAmountPositive(decimal amount) {
            if(amount < 0) {
                Console.WriteLine("Amout cannot be negative");
                return false;
            }
            return true;
        }


        public decimal AddSales(decimal salesAmount) {  //acccumulate sales, return new sales total
            var valid = CheckAmountPositive(salesAmount);
            if(valid == true) {
            Sales += salesAmount;
            }
            return Sales;
        }
        private void Initialize() {  // call initialization routine from both constructors
            this.Id = ++nextIdNbr;
        }

        public Customer(string name, string city, string state) : this() { 
            this.Name = name;
            this.State = state;
            this.City = city;
            Initialize();
        }
        public Customer() {
            Initialize();

        }






    }
}
