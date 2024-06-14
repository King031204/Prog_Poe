using System.Windows;

namespace RecipeApp
{
    public partial class EnterIngredientWindow : Window
    {
        private Recipe recipe;
        private int ingredientNumber;

        public EnterIngredientWindow(Recipe recipe, int number)
        {
            InitializeComponent();
            this.recipe = recipe;
            ingredientNumber = number;
            Title = $"Enter Ingredient {number} Details";
        }

        private void AddIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            string name = IngredientNameTextBox.Text;
            double quantity, calories;
            string unit = UnitTextBox.Text;
            string foodGroup = FoodGroupTextBox.Text;

            if (string.IsNullOrEmpty(name) || !double.TryParse(QuantityTextBox.Text, out quantity) || !double.TryParse(CaloriesTextBox.Text, out calories))
            {
                MessageBox.Show("Please enter valid details.", "Error");
                return;
            }

            recipe.AddIngredient(name, quantity, unit, calories, foodGroup);
            Close();
        }
    }
}
