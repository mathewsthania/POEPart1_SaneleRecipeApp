using System;
using System.CodeDom;
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
/// This class contains all my working methods, which I will call in the main class
/// It includes the:
/// 1. EnterRecipeDetails() method
/// 2. DisplayFinishedRecipe() method
/// 3. HalfRecipe() method
/// 4. DoubleRecipe() method
/// 5. TripleRecipe() method

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<*THE*START*OF*FILE*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

namespace SaneleRecipeApp.Classes
{
	public class RecipeMethods
	{
		// Creating string to store Recipe Name
		public string RecipeName { get; set; }

		// creating a array list to store the original ingredient measurements of specific inputted recipe
		private List<RecipeIngredients> originalScale;

		// Creating two array lists to store - ingredients + steps.
		public List<RecipeIngredients> Ingredients { get; set; } // To store the recipe ingredients.
		public List<string> Steps { get; set; } // TGo store the steps of the recipe.


		// Initializing the two lists - so that it can allow us to add items to each one.
		public RecipeMethods()
		{
			Ingredients = new List<RecipeIngredients>();
			Steps = new List<string>();
			originalScale = new List<RecipeIngredients>();
		}

		// Method created, to allow the user to enter the recipe ingredients and steps.
		public void EnterRecipeDetails()
		{
			// Promting user to enter the name of the specific recipe
			Console.WriteLine("Enter Recipe Name: ");
			RecipeName = Console.ReadLine(); // using string I created earlier to store recipe name.

			// Prompting the user to enter the number of the ingredients required for the recipe.
			Console.WriteLine("Enter the number of ingredients required: ");

			int ingredientsRequired = Convert.ToInt32(Console.ReadLine()); // using "convert.ToInt32" - to conver the string to an integer.

			// Created loop to allow user to enter all ingredients - after the user enters amount of ingredients.
			// Therefore, if user enters 4, it will loop 4 times, for each ingredient.
			for (int i = 0; i < ingredientsRequired; i++)
			{

				Console.WriteLine($"Enter the details for this ingredient {i + 1}: ");

				Console.WriteLine("Ingredient Name: "); // User is asked to enter the ingredient name.
				string Name = Console.ReadLine();

				Console.WriteLine("Quantity: "); // User is asked to enter the quantity of ingridient - ie. 2 or 4
				double Quantity = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Unit: "); // User is asked to enter the unit of measuremnt - ie 2(CUPS) or 4(KG) etc.
				string Unit = Console.ReadLine();

				// Adding ingredients to the array list of ingredients 
				Ingredients.Add(new RecipeIngredients { Name = Name, Quantity = Quantity, Unit = Unit });
			}

			// Promting the user to enter the number of steps required for the specific recipe entered.
			Console.WriteLine("Enter the number of steps required: ");
			int numberOfSteps = Convert.ToInt32(Console.ReadLine());

			// Creating a loop for details of each step to be captured.
			for (int i = 0; i < numberOfSteps; i++)
			{
				Console.WriteLine($"Enter step {i + 1}: ");
				string step = Console.ReadLine();

				// Adding the recipe steps to the Steps arrayList
				Steps.Add(step);
			}

			// storing the original recipe ingredient measurements in arrayList (originalScale)
			originalScale.AddRange(originalScale);
		}

		// Method created to display the entire recipe, after user has entered all the ingredients + steps
		public void DisplayFinishedRecipe()
		{
			// Displaying the name of the specific recipe.
			Console.WriteLine($"Recipe: {RecipeName}");

			Console.WriteLine("Ingredients: "); // displaying the list of the ingredients - for the specific recipe.

			// using for each loop - to loop + display each ingredient in the recipe.
			foreach (var ingredient in Ingredients)
			{
				// name, quantitiy and unit for each ingredient
				Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}");
			}

			// Displaying all the necessary steps included - for the specific recipe 
			Console.WriteLine("Steps: ");

			for (int i = 0; i < Steps.Count; i++) // creating for loop - to loop through + display all steps + the index of array -eg) 1. Cut Onions... 2. Fry Onions.
			{
				Console.WriteLine($"{i + 1}. {Steps[i]}");
			}
		}

		
		public void HalfRecipe()
		{
			List<RecipeIngredients> halfIngredients = new List<RecipeIngredients>();

			foreach (var ingredient in Ingredients)
			{
				RecipeIngredients halfIngredient = new RecipeIngredients
				{
					Name = ingredient.Name,
					Quantity = ingredient.Quantity *= 0.5,
					Unit = ingredient.Unit,
				};

				halfIngredients.Add(halfIngredient);
			}

			// Displaying the name of the specific recipe.
			Console.WriteLine($"Halved Recipe: {RecipeName}");

			Console.WriteLine("Ingredients: "); // displaying the list of the ingredients - for the specific recipe.

			// using for each loop - to loop + display each ingredient in the recipe.
			foreach (var ingredient in halfIngredients)
			{
				// name, quantitiy and unit for each ingredient
				Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}");
			}

			// Displaying all the necessary steps included - for the specific recipe 
			Console.WriteLine("Steps: ");

			for (int i = 0; i < Steps.Count; i++) // creating for loop - to loop through + display all steps + the index of array -eg) 1. Cut Onions... 2. Fry Onions.
			{
				Console.WriteLine($"{i + 1}. {Steps[i]}");
			}
		}

		public void DoubleRecipe()
		{
			List<RecipeIngredients> doubleIngredients = new List<RecipeIngredients>();

			foreach (var ingredient in Ingredients)
			{
				RecipeIngredients doubleIngredient = new RecipeIngredients
				{
					Name = ingredient.Name,
					Quantity = ingredient.Quantity *= 2,
					Unit = ingredient.Unit,
				};

				doubleIngredients.Add(doubleIngredient);
			}

			// Displaying the name of the specific recipe.
			Console.WriteLine($"Doubled Recipe: {RecipeName}");

			Console.WriteLine("Ingredients: "); // displaying the list of the ingredients - for the specific recipe.

			// using for each loop - to loop + display each ingredient in the recipe.
			foreach (var ingredient in doubleIngredients)
			{
				// name, quantitiy and unit for each ingredient
				Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}");
			}

			// Displaying all the necessary steps included - for the specific recipe 
			Console.WriteLine("Steps: ");

			for (int i = 0; i < Steps.Count; i++) // creating for loop - to loop through + display all steps + the index of array -eg) 1. Cut Onions... 2. Fry Onions.
			{
				Console.WriteLine($"{i + 1}. {Steps[i]}");
			}
		}

		public void TripleRecipe()
		{
			List<RecipeIngredients> tripleIngredients = new List<RecipeIngredients>();

			foreach (var ingredient in Ingredients)
			{
				RecipeIngredients tripleIngredient = new RecipeIngredients
				{
					Name = ingredient.Name,
					Quantity = ingredient.Quantity *= 3,
					Unit = ingredient.Unit,
				};

				tripleIngredients.Add( tripleIngredient );
			}

			// Displaying the name of the specific recipe.
			Console.WriteLine($"Trippled Recipe: {RecipeName}");
			
			Console.WriteLine("Ingredients: "); // displaying the list of the ingredients - for the specific recipe.

			// using for each loop - to loop + display each ingredient in the recipe.
			foreach (var ingredient in tripleIngredients)
			{
				// name, quantitiy and unit for each ingredient
				Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}");
			}

			// Displaying all the necessary steps included - for the specific recipe 
			Console.WriteLine("Steps: ");

			for (int i = 0; i < Steps.Count; i++) // creating for loop - to loop through + display all steps + the index of array -eg) 1. Cut Onions... 2. Fry Onions.
			{
				Console.WriteLine($"{i + 1}. {Steps[i]}");
			}
		}
	}
}


//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<*THE*END*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
