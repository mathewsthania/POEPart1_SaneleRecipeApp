using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thania_PROG6221_POE.Classes;

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
			Console.WriteLine("Welcome to Sanele's Recipe App!");

			// creating boolean to initialize exit to false - so that the program does not close yet.
			bool exit = false;

			// creating loop - so that while the program is still running it must do the following.
			while (!exit)
			{
				Console.WriteLine("1. Enter a new recipe.");
				Console.WriteLine("2. Clear all data.");
				Console.WriteLine("3. Exit Application");

				int choice = Convert.ToInt32(Console.ReadLine()); // allowing the users no. choice to be converted to int

				// creating a switch to display the different options that the user can choose from.
				switch (choice)
				{
					case 1:
						Console.WriteLine("Enter Reciple Details:");
						Recipe recipe1 = new Recipe();
						recipe1.EnterRecipeDetails();

						Console.WriteLine("Recipe:");
						recipe1.DisplayRecipe();
						break;

					case 2:
						Console.WriteLine("Recipe details have been cleared, please enter a new recipe.");
						break;

					case 3:
						exit = true;
						Console.WriteLine("Exiting Sanele's Recipe App....");
						break;

				}
			}
		}
	}
}

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<*THE*END*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
