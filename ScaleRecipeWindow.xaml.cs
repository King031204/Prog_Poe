using System.Collections.Generic;
using System.Windows;

namespace RecipeApp
{
    public partial class ScaleRecipeWindow : Window
    {
        private List<Recipe> recipes;
        private RecipeHandler recipeHandler;

        public ScaleRecipeWindow(RecipeHandler handler)
        {
            InitializeComponent();
            recipeHandler = handler;
            recipes = new List<Recipe>(recipeHandler.GetRecipes());
            RecipeComboBox.ItemsSource = recipes;
        }

        private void ScaleButton_Click(object sender, RoutedEventArgs e)
        {
            if (RecipeComboBox.SelectedItem is Recipe selectedRecipe && double.TryParse(ScalingFactorTextBox.Text, out double factor))
            {
                selectedRecipe.Scale(factor);
                MessageBox.Show("Recipe scaled successfully.", "Success");
            }
            else
            {
                MessageBox.Show("Please select a recipe and enter a valid scaling factor.", "Error");
            }
        }
    }
}
