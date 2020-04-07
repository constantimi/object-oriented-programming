using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    class Sandwich : Bakery
    {
        // Variables
        private string name;
        private double price;
        private string nameAndPrice;

        // Properties
        private Bread bread;
        private List<Ingredient> ingredients;

        // Getters and Setters
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string NameAndPrice { get => nameAndPrice; set => nameAndPrice = value; }
        internal Bread Bread { get => bread; private set => bread = value; }
        internal List<Ingredient> Ingredients { get => ingredients; private set => ingredients = value; }

        // Default constructor
        public Sandwich()
        {

        }

        public Sandwich(string name, Bread bread)
        {
            this.name = name;
            this.bread = bread;
            this.Ingredients = new List<Ingredient>();
            this.nameAndPrice = getInformation();
        }

        // Methods

        /// 
        /// This method returns a bool which will be false when
        /// the ingredient already exists on the sandwich.
        /// This method also has an out parameter called “MoreThan5”.
        /// This will return false when there are more than 5 ingredients
        /// on a sandwich. Implement this method. 
        /// 
        public bool AddIngredient(Ingredient ingredient, bool add)
        {
            
            // check if exists in the list
            
            bool uniqueItems = !this.Ingredients.Any(item => item.IngredientType == ingredient.IngredientType);
           

            if (uniqueItems)
            {
                    // Add more ingredients
                    this.Ingredients.Add(ingredient);
                    this.nameAndPrice = getInformation();

                    return add;                
            }           

            return !add;
        }

        /// 
        /// Calculates the price for the each sandwich and returns 
        /// string with the information. 
        /// 
        private string getInformation()
        {
            this.price = this.bread.PriceBread;

            foreach (var item in this.Ingredients)
            {
                this.price += item.PriceIngredient;
            }

            return $"{this.bread.BreadType} {this.name} - " + String.Format("{0:0.00}", this.price);
        }
        
    }
}
