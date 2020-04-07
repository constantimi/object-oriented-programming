using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    class Bakery
    {
        // Variables
        private string name;

        // Properties
        private List<Sandwich> sandwiches;

        // Getters and Setters
        public string Name { get => name; set => name = value; }
        internal List<Sandwich> Sandwiches { get => sandwiches; private set => sandwiches = value; }

        // Default constructor
        public Bakery()
        {
            this.Sandwiches = new List<Sandwich>();
        }

        public Bakery(string name)
        {
            this.name = name;
            this.Sandwiches = new List<Sandwich>();
        }

        // Methods 

        /// 
        ///  This methods adds a new sandwich. 
        ///  The name of the sandwich must be unique. 
        ///  When this is not the case, the method should
        ///  return false and the sandwich will not be added.
        ///  Otherwhises, the method return true and the sandwich
        ///  is added to the list of sandwiches. 
        /// 
        public bool AddSandwich(Sandwich sandwich)
        {
            bool uniqueItem = !this.Sandwiches.Any(item => item.Name == sandwich.Name);

            if (uniqueItem)
            {
                this.Sandwiches.Add(sandwich);
                return true;
            }

            return false;
        }
        
    }
}
