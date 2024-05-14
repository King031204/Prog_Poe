using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prog_Poe
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Manager manager = new Manager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Welcome to my Recipe Application!");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1. Enter And Save Recipe");
                Console.WriteLine("2. Display Saved Recipe");
                Console.WriteLine("3. Scale Recipe");
                Console.WriteLine("4. Reset Quantities");
                Console.WriteLine("5. Clear All Recipe Data");
                Console.WriteLine("6. Exit");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Select Your Choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                       manager.EnterAndSaveRecipe();
                        break;
                    case 2:
                        manager.DisplaySavedRecipes();
                        break;
                    case 3:
                        manager.ScaleRecipe();
                        break;
                    case 4:
                        manager.ResetQuantities();
                        break;

                    case 5:
                        manager.ClearAllRecipeData();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("------------------------------------");
            }
        }
    }
}
