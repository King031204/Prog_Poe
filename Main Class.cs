using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Poe
{
    internal class Class2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "************************************************************************************************************************" + "\n" +
                "                                                   Welcome To Recipe Haven" + "\n" +
                "************************************************************************************************************************");
            Recipe[] recipes = new Recipe[0];
            int recipeCount = 0;

            while (true)
            {
                //Get Input for Number of Recipes
                Console.Write("Enter the number of Recipes: ");
                int RecipeNumber = Convert.ToInt32(Console.ReadLine());

                string[] nameOfRecipe = new string[RecipeNumber];

                for (int i = 0; i < RecipeNumber; i++)
                {
                    //Get Name of Recipe
                    Console.WriteLine($"Enter the name of the Recipe {i + 1}: ");
#pragma warning disable CS8601 // Possible null reference assignment.
                    nameOfRecipe[i] = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                }
                //Get Input for Number of Ingredients
                Console.Write("Enter the number of ingredients: ");
                int NumberOfIngredients = Convert.ToInt32(Console.ReadLine());

                string[] ingredients = new string[NumberOfIngredients];
                double[] ingredientQuantities = new double[NumberOfIngredients];
                string[] unitOfMeasurement = new string[NumberOfIngredients];

                for (int i = 0; i < NumberOfIngredients; i++)
                {
                    //Get Name of Ingredients
                    Console.WriteLine($"Enter the name of Ingredient {i + 1}: ");
#pragma warning disable CS8601 // Possible null reference assignment.
                    ingredients[i] = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.

                    //Get Unit of Measurements for Ingredients
                    Console.WriteLine($"Enter the Unit of Measurement of Ingredient {i + 1}: ");
#pragma warning disable CS8601 // Possible null reference assignment.
                    unitOfMeasurement[i] = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.

                    //Get Quantity of Ingredients
                    Console.WriteLine($"Enter the Quantity for Ingredient {i + 1}: ");
                    ingredientQuantities[i] = Convert.ToDouble(Console.ReadLine());
                }

                // Get input for the Number of Steps
                Console.WriteLine("Enter the number of Steps: ");
                int numberOfSteps = Convert.ToInt32(Console.ReadLine());

                string[] steps = new string[numberOfSteps];

                for (int s = 0; s < numberOfSteps; s++)
                {
                    // Get Description of Steps
                    Console.WriteLine($"Enter the Description of Step {s + 1}: ");
#pragma warning disable CS8601 // Possible null reference assignment.
                    steps[s] = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                }

                // Create a new recipe object with the provided ingredients and steps
                Recipe recipe = new Recipe(RecipeNumber,nameOfRecipe,NumberOfIngredients, ingredients, ingredientQuantities, unitOfMeasurement, numberOfSteps, steps);
                Console.WriteLine("Recipe:");
                recipe.Display();


                Console.WriteLine("Enter Scaling Factor (0.5, 2, or 3) or enter 'reset' to reset the Quantities : ");

                double scalingFactor = Convert.ToDouble(Console.ReadLine());

                // Scale the ingredient quantities
                for (int i = 0; i < NumberOfIngredients; i++)
                {
                    ingredientQuantities[i] *= scalingFactor;
                }

                Recipe scaledRecipe = new Recipe(RecipeNumber,nameOfRecipe,NumberOfIngredients, ingredients, ingredientQuantities, unitOfMeasurement, numberOfSteps, steps);

                Console.WriteLine("Scaled Recipe:");
                scaledRecipe.Display();

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                if (input == "0.5")
                {
                    double factor = Convert.ToDouble(input);
                    recipe.Scale(factor);
                }
                if (input == "2")
                {
                    double factor = Convert.ToDouble(input);
                    recipe.Scale(factor);
                }
                if (input == "3")
                {
                    double factor = Convert.ToDouble(input);
                    recipe.Scale(factor);
                }
                else if (input == "reset")
                {
                    recipe.ResetIngredientQuantities();
                    recipe.Display();
                }
                Console.WriteLine("Enter 'clear' to clear all data(If data is cleared you will be able to input a new recipe), otherwise " + "\n" +
                    "Enter display' to show all recipes, or 'stop' to end off session: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.



                if (input == "clear")
                {
                    recipe.Clear();
                    recipeCount = 0;
                }
                else if (input == "display")
                {
                    Console.WriteLine("All Recipes:");
                    foreach (Recipe r in recipes)
                    {
                        r.Display();
                    }
                }

                if (input == "stop")
                {
                    Console.WriteLine("Thank you for using Recipe Haven!");
                    break;//exit loop
                }
                else
                {
                    recipe.Reset();
                }
                recipes[recipeCount] = scaledRecipe;
                recipeCount++;// Add the recipe to the array
            }
        }
    }
}

