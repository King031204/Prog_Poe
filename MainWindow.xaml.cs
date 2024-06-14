using System.Windows;

namespace RecipeApp
{
    public partial class MainWindow : Window
    {
        private RecipeHandler recipeHandler;

        public MainWindow()
        {
            InitializeComponent();
            recipeHandler = new RecipeHandler();
        }

        private void EnterRecipeDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            EnterRecipeWindow enterRecipeWindow = new EnterRecipeWindow(recipeHandler);
            enterRecipeWindow.Show();
        }

        private void ViewRecipesButton_Click(object sender, RoutedEventArgs e)
        {
            ViewRecipesWindow viewRecipesWindow = new ViewRecipesWindow(recipeHandler);
            viewRecipesWindow.Show();
        }

        private void ChooseRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            ChooseRecipeWindow chooseRecipeWindow = new ChooseRecipeWindow(recipeHandler);
            chooseRecipeWindow.Show();
        }

        private void ScaleRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            ScaleRecipeWindow scaleRecipeWindow = new ScaleRecipeWindow(recipeHandler);
            scaleRecipeWindow.Show();
        }

        private void ResetQuantitiesButton_Click(object sender, RoutedEventArgs e)
        {
            recipeHandler.ResetQuantities();
            MessageBox.Show("All quantities have been reset.", "Reset Quantities");
        }

        private void ClearAllDataButton_Click(object sender, RoutedEventArgs e)
        {
            recipeHandler.ClearData();
            MessageBox.Show("All data has been cleared.", "Clear All Data");
        }
    }
}
