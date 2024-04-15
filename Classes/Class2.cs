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
/// Date: 2024/02/26
/// </summary>

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<*THE*START*OF*FILE*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

namespace Thania_PROG6221_POE.Classes
{
	public class Recipe
	{
		public List<Ingredient> Ingredients { get; set; }
		public List<string> Steps { get; set; }

		public Recipe() 
		{
			Ingredients = new List<Ingredient>();
			Steps = new List<string>();
		}

		public void EnterRecipeDetails()
		{
			Console.WriteLine("Enter the number of ingredients required: ");
			int ingredientsRequired = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < ingredientsRequired; i++)
			{
				Console.WriteLine($"Enter the details for this ingredient {i + 1}: ");
				
				Console.WriteLine("Name: ");
				string Name = Console.ReadLine();	

				Console.WriteLine("Quantity: ");
				double Quantity = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Unit: ");
				string Unit = Console.ReadLine();

				Ingredients.Add(new Ingredient { Name = Name, Quantity = Quantity, Unit = Unit });
			}

			Console.WriteLine("Enter the number of steps required: ");
			int numberOfSteps = Convert.ToInt32(Console.ReadLine());	

			for (int i = 0;i < numberOfSteps; i++)
			{
				Console.WriteLine($"Enter step { i + 1}: ");
				string step = Console.ReadLine();

				Steps.Add(step);
			}
		}

		// method to display the finished recipe, after user has entered it
		public void DisplayRecipe()
		{
			Console.WriteLine("Ingredients: ");
			
			foreach ( var ingredient in Ingredients)
			{
				Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}");
			}

			Console.WriteLine("Steps: ");
			
			for ( int i = 0; i < Steps.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {Steps[i]}");
			}
		}

	}
}

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<*THE*END*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
