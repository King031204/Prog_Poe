using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Poe
{
    class Manager
    {
        private List<Recipe> recipes;

        public Manager()
        {
            recipes = new List<Recipe>();
        }

        public void EnterAndSaveRecipe()
        {
            Console.WriteLine("Enter the name of the recipe: ");
            string name = Console.ReadLine();

            Console.WriteLine("Input the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());

            List<Ingredients> ingredients = new List<Ingredients>();

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine("Enter the name of ingredient {0}: ", i + 1);
                string ingredientName = Console.ReadLine();

                Console.WriteLine("Input the quantity of ingredient: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.WriteLine("Input the unit of measurement: ");
                string unit = Console.ReadLine();

                Console.WriteLine("Input the number of calories: ");
                int calories = int.Parse(Console.ReadLine());

                Console.WriteLine("Input the food group the ingredient falls under: ");
                string foodGroups = Console.ReadLine();

                Ingredients ingredient = new Ingredients(ingredientName, quantity, unit, calories, foodGroups);
                ingredients.Add(ingredient);
            }

            Console.WriteLine("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            List<string> steps = new List<string>();

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine("Enter step {0}: ", i + 1);
                string step = Console.ReadLine();
                steps.Add(step);
            }

            Recipe recipe = new Recipe(name, ingredients, steps);
            recipes.Add(recipe);

            CalorieCalculator calorieCalculator = new CalorieCalculator(name, ingredients, steps);
            int totalCalories = calorieCalculator.CalculateTotalCalories();

            Console.WriteLine($"Total Calories: {totalCalories}");

            if (totalCalories > 300)
            {
                Console.WriteLine("Total calories of the recipe exceed 300!");
            }

            Console.WriteLine("Recipe has been saved successfully.");
        }

        public void DisplaySavedRecipes()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipe found. Please enter and save recipe first.");
            }
            else
            {
                Console.WriteLine("Saved Recipes:");
                for (int i = 0; i < recipes.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, recipes[i].name);
                }

                Console.WriteLine("Enter the number of the recipe to display or enter '0' to display all recipes: ");
                int selectedRecipeIndex = int.Parse(Console.ReadLine());

                if (selectedRecipeIndex >= 0 && selectedRecipeIndex <= recipes.Count)
                {
                    if (selectedRecipeIndex == 0)
                    {
                        recipes.Sort((r1, r2) => r1.name.CompareTo(r2.name));
                        foreach (Recipe recipe in recipes)
                        {
                            Console.WriteLine(recipe.ToString());
                        }
                    }
                    else
                    {
                        Recipe selectedRecipe = recipes[selectedRecipeIndex - 1];
                        Console.WriteLine(selectedRecipe.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Invalid recipe number. Please try again.");
                }
            }
        }

        public void ScaleRecipe()
        {
            Console.WriteLine("Enter scale factor (0.5, 2, or 3): ");
            double scaleFactor = double.Parse(Console.ReadLine());

            foreach (Recipe recipe in recipes)
            {
                recipe.ScaleQuantities(scaleFactor);
            }

            Console.WriteLine("Recipe scaled successfully.");
        }

        public int CalculateTotalCalories()
        {
            int totalCalories = 0;

            foreach (Recipe recipe in recipes)
            {
                foreach (Ingredients ingredient in recipe.ingredients)
                {
                    totalCalories += ingredient.Calories;
                }
            }
           
            return totalCalories;
        }

        public void ResetQuantities()
        {
            foreach (Recipe recipe in recipes)
            {
                recipe.ResetQuantities();
            }

            Console.WriteLine("Quantities reset successfully.");
        }

        public void ClearAllRecipeData()
        {
            recipes.Clear();
            Console.WriteLine("All recipe data cleared successfully.");
        }
    }
}
