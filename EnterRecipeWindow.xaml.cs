using System.Windows;

namespace RecipeApp
{
    public partial class EnterRecipeWindow : Window
    {
        private RecipeHandler recipeHandler;

        public EnterRecipeWindow(RecipeHandler handler)
        {
            InitializeComponent();
            recipeHandler = handler;
        }

        private void AddIngredientsButton_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = RecipeNameTextBox.Text;
            int numIngredients;

            if (string.IsNullOrEmpty(recipeName) || !int.TryParse(NumIngredientsTextBox.Text, out numIngredients))
            {
                MessageBox.Show("Please enter valid details.", "Error");
                return;
            }

            Recipe recipe = new Recipe { Name = recipeName };

            for (int i = 0; i < numIngredients; i++)
            {
                EnterIngredientWindow enterIngredientWindow = new EnterIngredientWindow(recipe, i + 1);
                enterIngredientWindow.ShowDialog();
            }

            recipeHandler.AddRecipe(recipe);
            MessageBox.Show("Recipe details entered successfully.", "Success");
            Close();
        }
    }
}
