using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Poe
{
    class Recipe
    {
        public int RecipeNumber { get; set; }
        public string[] NameOfRecipe { get; set; }
        public int NumberOfIngredients { get; set; }
        public string[] Ingredients { get; set; }
        public double[] IngredientQuantities { get; set; }
        public string[] UnitOfMeasurement { get; set; }
        public int NumberOfSteps { get; set; }
        public string[] Steps { get; set; }

        public Recipe()
        {
            RecipeNumber = 0;
            NameOfRecipe = new string[0];
            NumberOfIngredients = 0;
            Ingredients = new string[0];
            IngredientQuantities = new double[0];
            UnitOfMeasurement = new string[0];
            NumberOfSteps = 0;
            Steps = new string[0];
        }

        public Recipe(int recipeNumber,string[] nameOfRecipe,int numberOfIngredients, string[] ingredients, double[] ingredientQuantities, string[] unitOfMeasurement, int numberOfSteps, string[] steps)
        {
            RecipeNumber = recipeNumber;
            NameOfRecipe = nameOfRecipe;
            NumberOfIngredients = numberOfIngredients;
            Ingredients = ingredients;
            IngredientQuantities = ingredientQuantities;
            UnitOfMeasurement = unitOfMeasurement;
            NumberOfSteps = numberOfSteps;
            Steps = steps;

        }
        public void Scale(double factor)
        {
            for (int i = 0; i < UnitOfMeasurement.Length; i++)
            {
                IngredientQuantities[i] *= factor;
            }
        }
        public void ResetIngredientQuantities()
        {
            // Quantities will be reset to their original values (should said values be stored in an array)

        }

        public void Display()
        {

            Console.WriteLine("Recipe:");
            for (int i = 0; i < NameOfRecipe.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + NameOfRecipe[i]);
            }
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < Ingredients.Length; i++)
            {
                Console.WriteLine(IngredientQuantities[i] + " " + UnitOfMeasurement[i] + " of " + Ingredients[i]);
            }

            Console.WriteLine("Steps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + Steps[i]);
            }
        }

        public void Clear()
        {
            RecipeNumber = 0;
            NameOfRecipe = new string[0];
            NumberOfIngredients = 0;
            Ingredients = new string[0];
            IngredientQuantities = new double[0];
            UnitOfMeasurement = new string[0];
            NumberOfSteps = 0;
            Steps = new string[0];
        }

        public void Reset()
        {
            Clear();
            // Reset any other variables or states
        }
    }
}
