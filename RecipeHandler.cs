using System.Collections.Generic;

namespace RecipeApp
{
    public class RecipeHandler
    {
        private List<Recipe> recipes = new List<Recipe>();

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public IEnumerable<Recipe> GetRecipes()
        {
            return recipes;
        }

        public void ResetQuantities()
        {
            foreach (var recipe in recipes)
            {
                recipe.ResetQuantities();
            }
        }

        public void ClearData()
        {
            recipes.Clear();
        }
    }
}
