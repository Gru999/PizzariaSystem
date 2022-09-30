using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSystem
{
    internal class Customer
    {
        //Instance variable
        //private string _name;
        //private int _phone;
        private int _id = 0;
        
        //Property
        public string Name { get; set; }
        public int Phone { get; set; }
        public int Id { 
            get { return _id; }
            set { _id++; }
        }

        //Constructor
        public Customer(string name, int phone) { 
            Name = name;
            Phone = phone;
            
        }

        //Methode
        public override string ToString()
        {
            return $"Customer name: {Name}\n " +
                   $"----------------------------------\n " +
                   $"Phone Number: {Phone}\n " +
                   $"----------------------------------\n " +
                   $"Customer ID: {Id}\n " +
                   $"----------------------------------\n ";
        }
    }
}
