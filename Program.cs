using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SaneleRecipeApp.Classes;

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

/// <summary>
/// Thania Mathews
/// StID: ST10381071
/// Module: PROG6221
/// Date: 2024/03/15
/// - SUMMARY OF POE P1 -
/// Designing an application for Sanele, to learn how to cook.
/// What the command-line application includes:
/// 1. User is able to enter details for a single recipe.
/// 2. The number of ingredients.
/// 3. Each ingredient: name, quantity, unit of measurement.
/// 4. The number of steps.
/// 5. For each step, a description of what the user should do.
/// 6. The user should be able to scale the recipe in half (0.5), double (2) or triple (3).
/// 7. The user can request the quantities to be reset to the original values.
/// 8. The user must be able to clear the data, to enter a new recipe.
/// Data will only be stored while the software programme is running.
/// </summary>

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

namespace SaneleRecipeApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
            // Creating an opening line to welcome the user to the application and a line to show the Main Menu
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Sanele's Recipe App!");
            Console.ResetColor();

            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("Main Menu:");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Please select an option from the menu.");
            Console.WriteLine("------------------------------------------------------------------------------");


            // Creating an object of the RecipeMethods class - so that we can access the specific methods that we need
            SaneleRecipeApp.Classes.RecipeMethods1 recipe1 = new SaneleRecipeApp.Classes.RecipeMethods1();

			// Creating loop - so that while the program is still running it must do the following.
			while (true)
			{
				Console.WriteLine("1. Enter a new Recipe."); // enter a new recipe
				Console.WriteLine("2. Display and manage all Recipes"); // scale the recipe - multiplying by 0.5/2/3
				Console.WriteLine("3. Clear all data."); // clears all data in the application (reset)
				Console.WriteLine("4. Exit Application.");

				// converting the users choice into int
				int userChoice = Convert.ToInt32(Console.ReadLine());

				// Creating a switch - to create actions for each of the options the user can choose from
				switch (userChoice)
				{
					// case 1 calls the enterRecipeDetails() method to allow the user to enter the details of the recipe
					case 1:
						Console.WriteLine("------------------------------------------------------------------------------");
						Console.WriteLine("");
						RecipeMethods1 newRecipe = new RecipeMethods1();
						newRecipe.EnterRecipeDetails();
						Console.WriteLine("");
						Console.WriteLine("------------------------------------------------------------------------------");
						newRecipe.DisplayFinishedRecipe(); // calls the DisplayFinishedRecipe() method by using the recipe1 object - displays the entire recipe after user enters recipe details.
						Console.WriteLine("");
						Console.WriteLine("------------------------------------------------------------------------------");
						break;

					case 2:
						if (RecipeMethods1.AllRecipes.Count == 0)
						{
							Console.WriteLine("No recipes available to display or manage..");
							break;
						}

                        Console.ForegroundColor = ConsoleColor.Yellow; // adding in colour text to make my application more advanced

						// Displaying the name of the specific recipe.
						Console.WriteLine("Recipes: ");
                        Console.ResetColor(); // resets the colour back to the standard console colour (WHITE).

						
                        Console.WriteLine("------------------------------------------------------------------------------");
						recipe1.displayRecipeNames();
                        Console.WriteLine("------------------------------------------------------------------------------");
						Console.WriteLine("");

						Console.WriteLine("Please select a recipe to manage: ");

						int selectedRecipeNumber;
						if (int.TryParse(Console.ReadLine(), out selectedRecipeNumber) && selectedRecipeNumber > 0 && selectedRecipeNumber <= RecipeMethods1.AllRecipes.Count)
						{
							string selectedRecipeName = RecipeMethods1.AllRecipes.Keys.OrderBy(name => name).ToList()[selectedRecipeNumber - 1];
							RecipeMethods1.AllRecipes[selectedRecipeName].RecipeChange();
						}
						else
						{
							Console.WriteLine("Invalid number selection, please try again!");
						}
						break;

					case 3:
						// adding error handling - to make sure user wants to delete
						Console.WriteLine("Are you sure you would like to clear the recipe? [Yes(y)/No(n)]");
						string confirmationMessage = Console.ReadLine().ToLower();

						// creating confirmation message to confirm deletion
						if (confirmationMessage == "yes" || confirmationMessage == "y")
						{
							recipe1.ClearAllRecipeData(); // calls the ClearAllRecipeData() method by using the recipe1 object. - clears all aplication data.
							Console.WriteLine("All Recipe data has been cleared successfully!");
						}
						else
						{
							Console.WriteLine("Not clearing data...");
						}
						break;

					case 4: 
						Console.WriteLine("Exiting Recipe Application..... We hope to see you soon!");
						return; // exits application

					default:
						Console.WriteLine("Invalid Option, please try again and choose a number FROM 1 TO 4!");
						break; // default made, incase user enters a number outside the options list.
				}



            }
        }
	}
}

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<*THE*END*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
