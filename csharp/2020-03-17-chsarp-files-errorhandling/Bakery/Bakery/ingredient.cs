using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    class Ingredient : Sandwich
    {
        // Variables
        private string desciption;
        private IngredientType ingredientType;
        private double price;

        // Getters and Setters
        public string Desciption { get => desciption; set => desciption = value; }
        public double PriceIngredient { get => price; set => price = value; }
        internal IngredientType IngredientType { get => ingredientType; set => ingredientType = value; }
        
        // Default constructor
        public Ingredient()
        {

        }

        public Ingredient(string description, IngredientType ingredientType, double price)
        {
            this.desciption = desciption;
            this.ingredientType = ingredientType;
            this.price = price;
        }

    }
}
