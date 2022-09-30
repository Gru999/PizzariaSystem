using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSystem
{
    internal class Order
    {
        //Instance fields
        DateTime _time = DateTime.Now;
        private Pizza _pizza;
        private Customer _nameOfCust;
        
        //Properties
        public DateTime Time {
            get { return _time; }
        }

        public Pizza Pizza {
            get { return _pizza; }
            set { _pizza = value; }
        }
 
        public Customer NameOfCust {
            get { return _nameOfCust; }
            set { _nameOfCust = value; }
        }

        //Constructor
        public Order(Pizza pizza, Customer nameOfCust) {
            _pizza = pizza;
            _nameOfCust = nameOfCust;
        }

        //Methode
        public override string ToString() {
            return $"{_nameOfCust.ToString()}\n " +
                   $"{Time}\n " +
                   $"{_pizza.ToString()}\n ";
        }
    }
}
