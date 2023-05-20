using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect.Entities
{
    public class Stock
    {
        private static int noOfStocks = 0;  

        readonly int id;
        public string name { get; private set; }
        public decimal price { get; private set; }
        public decimal quantity { get; private set; }

        public decimal value { get; private set; }   
        

        public Stock(string name, decimal price, decimal quantity)
        {
            noOfStocks++;
            this.id = noOfStocks;
            this.name = name;
            this.price = price; 
            this.quantity = quantity;   
            this.value = price*quantity;

        }
    }
}
