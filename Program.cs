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

			// Creating an object of the RecipeMethods class - so that we can access the specific classes needed
			SaneleRecipeApp.Classes.RecipeMethods recipe1 = new SaneleRecipeApp.Classes.RecipeMethods();

			// Creating loop - so that while the program is still running it must do the following.
			while (true)
			{
				Console.WriteLine("Enter Reciple Details: ");
				recipe1.EnterRecipeDetails();
				Console.WriteLine(""); // creating space in between entering ingredients + steps and the displayed full recipe details
				Console.WriteLine("------------------------------------------------------------------------------");
				Console.WriteLine("");
				recipe1.DisplayFinishedRecipe();
				Console.WriteLine("");
				Console.WriteLine("------------------------------------------------------------------------------");
				Console.WriteLine(""); // creating space in between the fully displayed recipe and the loop of options

				Console.WriteLine("Would you like to scale the recipe? (Yes/No)");
				string userChoice = Console.ReadLine().ToLower();

				while (userChoice == "yes")
				{
					Console.WriteLine("How would you like to scale the recipe, please choose from the options below: ");
					Console.WriteLine("1. Half Recipe");
					Console.WriteLine("2. Double Recipe");
					Console.WriteLine("3. Triple Recipe");
					Console.WriteLine("4. Reset Recipe to original scale.");

					int userScalingOption = Convert.ToInt32(Console.ReadLine());

					switch (userScalingOption)
					{
						case 1:
							recipe1.HalfRecipe();
							continue;

						case 2:
							recipe1.DoubleRecipe();
							continue;

						case 3:
							recipe1.TripleRecipe();
							continue;

						case 4:
							recipe1.DisplayFinishedRecipe(); // calling method to display the original recipe that the user entered.
							continue;

						default:
							Console.WriteLine("Invalid Option, please try again and choose a number FROM 1 TO 6!");
							break;
					}
				}

			}
		}
	}
}

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<*THE*END*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
