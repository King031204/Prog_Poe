using System;
using System.Collections.Generic;

namespace RecipeApp
{
    public class Recipe
    {
        public string Name { get; set; }
        private List<Ingredient> ingredients = new List<Ingredient>();

        public void AddIngredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            ingredients.Add(new Ingredient(name, quantity, unit, calories, foodGroup));
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe: {Name}");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }

        public void Scale(double factor)
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.ResetQuantity();
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public List<string> GetIngredients()
        {
            List<string> ingredientDetails = new List<string>();
            foreach (var ingredient in ingredients)
            {
                ingredientDetails.Add(ingredient.ToString());
            }
            return ingredientDetails;
        }
    }



    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }
        private double originalQuantity;

        public Ingredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Calories = calories;
            FoodGroup = foodGroup;
            originalQuantity = quantity;
        }

        public void ResetQuantity()
        {
            Quantity = originalQuantity;
        }

        public override string ToString()
        {
            return $"{Name}: {Quantity} {Unit}, {Calories} calories, {FoodGroup}";
        }


    }
}
