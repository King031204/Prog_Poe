using System.Collections.Generic;
using System.Windows;

namespace RecipeApp
{
    public partial class ViewRecipesWindow : Window
    {
        private List<Recipe> recipes;

        public ViewRecipesWindow(RecipeHandler handler)
        {
            InitializeComponent();
            recipes = new List<Recipe>(handler.GetRecipes());
            RecipesListBox.ItemsSource = recipes;
        }

        private void RecipesListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (RecipesListBox.SelectedItem is Recipe selectedRecipe)
            {
                MessageBox.Show(selectedRecipe.ToString() + "\n" + string.Join("\n", selectedRecipe.GetIngredients()), "Recipe Details");
            }
        }
    }
}
