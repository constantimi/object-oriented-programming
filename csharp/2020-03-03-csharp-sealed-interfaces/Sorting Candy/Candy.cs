using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Candy
{
    class Candy : IComparable<Candy>
    {
        // Variables
        private double price;
        private string name;

        // Getters and Setters
        public double Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }

        // Defualt Constructor
        public Candy()
        {

        }

        // Constructor
        public Candy(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

       
        // Interface method
        public int CompareTo(Candy other)
        {
            if (this.Price == other.Price)
            {
                return this.Name.CompareTo(other.Name);
            }
            // Default to salary sort. [High to low]
            return this.Price.CompareTo(other.Price);
        }

        // Override Equals
        public override bool Equals(object obj)
        {
            // Check the type
            if(!(obj is Candy))
            {
                return false;
            }

            var other = obj as Candy;

            // Check the fields
            if(this.Name != other.Name || this.Price != other.Price)
            {
                return false;
            }

            return true;
        }

        // Override == and !=
        public static bool operator ==(Candy x, Candy y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(Candy x, Candy y)
        {
            return !(x == y);
        }

        // Methods
        public string GetInfo()
        {
            return $"{this.Name} : {this.Price}euro";
        }

       
    }
}
