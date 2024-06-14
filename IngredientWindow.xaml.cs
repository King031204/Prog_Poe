using System.Windows;

namespace RecipeApp
{
    public partial class IngredientWindow : Window
    {
        public Ingredient Ingredient { get; private set; }

        public IngredientWindow()
        {
            InitializeComponent();
        }

        private void SaveIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(QuantityTextBox.Text, out double quantity) &&
                double.TryParse(CaloriesTextBox.Text, out double calories))
            {
                Ingredient = new Ingredient(IngredientNameTextBox.Text, quantity, UnitTextBox.Text, calories, FoodGroupTextBox.Text);
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Please enter valid values for quantity and calories.");
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
