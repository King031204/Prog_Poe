using System.Collections.Generic;
using System.Windows;

namespace RecipeApp
{
    public partial class ChooseRecipeWindow : Window
    {
        private List<Recipe> recipes;
        private RecipeHandler recipeHandler;

        public ChooseRecipeWindow(RecipeHandler handler)
        {
            InitializeComponent();
            recipeHandler = handler;
            recipes = new List<Recipe>(recipeHandler.GetRecipes());
            ChooseRecipeListBox.ItemsSource = recipes;
        }

        private void SelectRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            if (ChooseRecipeListBox.SelectedItem is Recipe selectedRecipe)
            {
                selectedRecipe.DisplayRecipe();
            }
            else
            {
                MessageBox.Show("Please select a recipe.", "Error");
            }
        }
    }
}
