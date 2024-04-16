using System;
using System.Collections.Generic;
using System.Linq;
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
			// Creating an opening line to welcome the user to the application.
			Console.WriteLine("Welcome to Sanele's Recipe App!");
			Console.WriteLine("Main Menu:");

			// Creating an object of the RecipeMethods class - so that we can access the specific classes needed
			SaneleRecipeApp.Classes.RecipeMethods recipe1 = new SaneleRecipeApp.Classes.RecipeMethods();

			// Creating loop - so that while the program is still running it must do the following.
			while (true)
			{
				Console.WriteLine("1. Enter a new Recipe.");
				Console.WriteLine("2. Scale the Recipe.");
				Console.WriteLine("3. Clear all data.");
				Console.WriteLine("4. Exit Application.");

				int userChoice = Convert.ToInt32(Console.ReadLine());

				switch (userChoice)
				{
					case 1:
						Console.WriteLine("------------------------------------------------------------------------------");
						Console.WriteLine("");
						recipe1.EnterRecipeDetails();
						Console.WriteLine("");
						Console.WriteLine("------------------------------------------------------------------------------");
						recipe1.DisplayFinishedRecipe();
						Console.WriteLine("");
						Console.WriteLine("------------------------------------------------------------------------------");
						break;

					case 2:
						recipe1.ScaleRecipe();
						break;

					case 3:
						recipe1.ClearAllRecipeData();
						Console.WriteLine("All Recipe data has been cleared successfully!");
						break;

					case 4:
						Console.WriteLine("Exiting Recipe Application..... We hope to see you soon!");
						return;

					default:
						Console.WriteLine("Invalid Option, please try again and choose a number FROM 1 TO 6!");
						break;
				}
				

			}
		}
	}
}

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<*THE*END*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
