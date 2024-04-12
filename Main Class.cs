using System;

namespace Prog_Poe
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Recipe[] recipes = new Recipe[100];
            int recipeCount = 0;

            while (true)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Welcome To Recipe Haven");
                Console.WriteLine("=================================");

                Console.WriteLine("1. Add Recipe");
                Console.WriteLine("2. Show Saved Recipe");
                Console.WriteLine("3. Change Recipe Scale");
                Console.WriteLine("4. Reset Recipe Quantities");
                Console.WriteLine("5. Remove All Saved Recipes");
                Console.WriteLine("6. Close");
                Console.WriteLine("=================================");

                Console.Write("Input Selection: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        recipes[recipeCount] = EnterRecipe();
                        recipeCount++;
                        break;
                    case 2:
                        DisplayRecipes(recipes, recipeCount);
                        break;
                    case 3:
                        ScaleRecipe(recipes, recipeCount);
                        break;
                    case 4:
                        ResetQuantities(recipes, recipeCount);
                        break;
                    case 5:
                        ClearAllData(recipes, ref recipeCount);
                        break;
                    case 6:
                        Console.WriteLine("Thank you for using Recipe Haven!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static Recipe EnterRecipe()
        {

            Console.WriteLine("Enter the number of ingredients: ");
            int numberOfIngredients = Convert.ToInt32(Console.ReadLine());

            Ingredients[] ingredientList = new Ingredients[numberOfIngredients];

            for (int i = 0; i < numberOfIngredients; i++)
            {
                Console.WriteLine($"Enter the name of Ingredient {i + 1}: ");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter the Unit of Measurement of Ingredient {i + 1}: ");
                string unitOfMeasurement = Console.ReadLine();

                Console.WriteLine($"Enter the Quantity for Ingredient {i + 1}: ");
                double quantity = Convert.ToDouble(Console.ReadLine());

                ingredientList[i] = new Ingredients(name, quantity, unitOfMeasurement);
            }

            Console.WriteLine("Enter the number of Steps: ");
            int numberOfSteps = Convert.ToInt32(Console.ReadLine());

            string[] steps = new string[numberOfSteps];

            for (int s = 0; s < numberOfSteps; s++)
            {
                Console.WriteLine($"Enter the Description of Step {s + 1}: ");
                steps[s] = Console.ReadLine();
            }

            return new Recipe(ingredientList, numberOfSteps, steps);
        }

        public static void DisplayRecipes(Recipe[] recipes, int recipeCount)
        {
            if (recipeCount == 0)
            {
                Console.WriteLine("No recipe saved. Input recipe first.");
            }
            else
            {
                Console.WriteLine("All Recipes:");
                for (int i = 0; i < recipeCount; i++)
                {
                    Console.WriteLine($"Recipe {i + 1}:");
                    recipes[i].Display();
                }
            }
        }

        public static void ScaleRecipe(Recipe[] recipes, int recipeCount)
        {
            Console.Write("Enter the recipe number to scale: ");
            int recipeNumber = Convert.ToInt32(Console.ReadLine()) - 1;

            if (recipeNumber >= 0 && recipeNumber < recipeCount)
            {
                Console.WriteLine("Enter Scaling Factor (0.5, 2, or 3): ");
                double scalingFactor = Convert.ToDouble(Console.ReadLine());

                recipes[recipeNumber].Scale(scalingFactor);
                Console.WriteLine("Scaled Recipe:");
                recipes[recipeNumber].Display();
            }
            else
            {
                Console.WriteLine("Invalid recipe number.");
            }
        }

        public static void ResetQuantities(Recipe[] recipes, int recipeCount)
        {
            Console.Write("Enter the recipe number to reset quantities: ");
            int recipeNumber = Convert.ToInt32(Console.ReadLine()) - 1;

            if (recipeNumber >= 0 && recipeNumber < recipeCount)
            {
                recipes[recipeNumber].ResetIngredientQuantities();
                Console.WriteLine("Quantities reset for Recipe " + (recipeNumber + 1));
                recipes[recipeNumber].Display();
            }
            else
            {
                Console.WriteLine("Invalid recipe number.");
            }
        }

        public static void ClearAllData(Recipe[] recipes, ref int recipeCount)
        {
            Console.WriteLine("All data cleared.");
            for (int i = 0; i < recipeCount; i++)
            {
                recipes[i] = null;
            }
            recipeCount = 0;
        }
    }
}
