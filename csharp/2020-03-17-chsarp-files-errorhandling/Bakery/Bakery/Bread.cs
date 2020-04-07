using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    class Bread : Sandwich
    {
        // Variables
        private string description;
        private BreadType breadType;
        private double price;

        // Getters and Setters
        public string Description { get => description; set => description = value; }
        public double PriceBread { get => price; set => price = value; }
        internal BreadType BreadType { get => breadType; set => breadType = value; }
    
        // Default constructor
        public Bread()
        {

        }

        public Bread(string description, BreadType breadType, Double price)
        {
            this.description = description;
            this.breadType = breadType;
            this.price = price;
        }
    }
}
