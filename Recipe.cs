using System;

namespace Prog_Poe
{
    class Recipe
    {
        public Ingredients[] IngredientList { get; set; }
        public int NumberOfSteps { get; set; }
        public string[] Steps { get; set; }

        public Recipe(Ingredients[] ingredients, int numberOfSteps, string[] steps)
        {
            IngredientList = ingredients;
            NumberOfSteps = numberOfSteps;
            Steps = steps;
        }

        public void Display()
        {
           

            Console.WriteLine("Ingredients:");
            foreach (Ingredients ingredient in IngredientList)
            {
                ingredient.Display();
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < NumberOfSteps; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
        }

        public void Scale(double scalingFactor)
        {
            foreach (Ingredients ingredient in IngredientList)
            {
                ingredient.Quantity *= scalingFactor;
            }
        }

        public void ResetIngredientQuantities()
        {
            foreach (Ingredients ingredient in IngredientList)
            {
                ingredient.Quantity = 0;
            }
        }
    }
}
