using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSystem
{
    internal class Pizza
    {
        //have _pizzaNum be equal to a pizza from a list

        //Instance field
        private int _pno;
        private string _pn;
        private string _ing;
        private double _price;

        //Property
        public int Pno {
            get { return _pno; }
        }
        public string Pn { 
            get { return _pn; }
        }
        public string Ing { 
            get { return _ing; }
        }
        public double Price { 
            get { return _price; }
        }


        //Constructor
        public Pizza(int pno, string pn, string ing, double price) {
            _pno = pno;
            _pn = pn;
            _ing = ing;
            _price = price;
        }
        //methode
        public override string ToString()
        {
            return $"Pizza name: {_pn}\n " +
                   $"----------------------------------\n " +
                   $"Pizza number: {_pno} \n " +
                   $"----------------------------------\n " +
                   $"Ingridients: {_ing} \n " +
                   $"----------------------------------\n " +
                   $"Price: {_price} \n " +
                   $"----------------------------------\n ";
        }
    }
}
