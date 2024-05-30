using System;
using System.Collections.Generic;
using System.Linq;

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

/// <summary>
/// Thania Mathews
/// StID: ST10381071
/// Module: PROG6221
/// Date: 2024/02/26
/// </summary>
/// /// This class contains all my working methods, which I will call in the main class
/// It includes the:
/// 1. EnterRecipeDetails() method
/// 2. DisplayFinishedRecipe() method
/// 3. HalfRecipe() method
/// 4. DoubleRecipe() method
/// 5. TripleRecipe() method
/// 6. ScaleRecipe() method
/// 7. ResetRecipeToOriginalScale() method
/// 8. ClearAllRecipeData()
/// 
/// These methods all help to make our recipe application work and for it to carry out the necessary functions.
/// 

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<*THE*START*OF*FILE*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

namespace SaneleRecipeApp.Classes
{
    public class RecipeMethods1
	{
		// Creating string to store Recipe Name
		public string RecipeName { get; set; }

		// creating list of food groups for the user to choose from 
		private readonly List<string> foodGroups = new List<string> { "Fruits", "Vegetables", "Grains", "Protein", "Dairy"};

		// creating a array list to store the original ingredient measurements of specific inputted recipe
		private List<RecipeIngredients1> originalScale;

		// Creating two array lists to store - ingredients + steps.
		public List<RecipeIngredients1> Ingredients { get; set; } // To store the recipe ingredients.
		public List<string> Steps { get; set; } // TGo store the steps of the recipe.

		public static Dictionary<string, RecipeMethods1> AllRecipes = new Dictionary<string, RecipeMethods1>();

        // creating delegate to handle error message
        public delegate bool CaloriesExceedsAmount(double totalCalories);

		public double totalCalories { get; private set; }

        // Initializing the two lists - so that it can allow us to add items to each one.
        public RecipeMethods1()
		{
			Ingredients = new List<RecipeIngredients1>();
			Steps = new List<string>();
			originalScale = new List<RecipeIngredients1>();
		}

		// Method created, to allow the user to enter the recipe ingredients and steps.
		public void EnterRecipeDetails()
		{
			// Promting user to enter the name of the specific recipe
			Console.WriteLine("Enter Recipe Name: ");
			RecipeName = Console.ReadLine(); // using string I created earlier to store recipe name.

			// adding in error handling - updates from feedback given
			if (string.IsNullOrEmpty(RecipeName))
			{
				Console.WriteLine("Recipe name cannot be empty, please enter a valid Recipe name.");
				return;
			}

			// adding in error handling - updates from feedback given
			int ingredientsRequired;

			while (true)
			{
                // Prompting the user to enter the number of the ingredients required for the recipe.
                Console.WriteLine("Enter the number of ingredients required: ");
				if (int.TryParse(Console.ReadLine(),out ingredientsRequired) && ingredientsRequired > 0)
				{
					break;
				}
				else
				{
					Console.WriteLine("Invalid input, please enter a valid number of ingredients.");	
				}
            }

			// Created loop to allow user to enter all ingredients - after the user enters amount of ingredients.
			// Therefore, if user enters 4, it will loop 4 times, for each ingredient.
			for (int i = 0; i < ingredientsRequired; i++)
			{

				Console.WriteLine($"Enter the details for this ingredient {i + 1}: ");

				Console.WriteLine("Ingredient Name: "); // User is asked to enter the ingredient name.
				string Name = Console.ReadLine();

                // adding in error handling - updates from feedback given
				if (string.IsNullOrEmpty(Name))
				{
					Console.WriteLine("Ingredient name cannot be empty, please enter a valid Ingredient name.");
					continue;
				}

				// adding in error handling - updates from feedback given
				double Quantity;
				while (true)
				{
					Console.WriteLine("Quantity: "); // User is asked to enter the quantity of ingridient - ie. 2 or 4
					if ((double.TryParse(Console.ReadLine(), out Quantity)) && Quantity > 0)
					{
						break;
					}
					else
					{
						Console.WriteLine("Invalid input! Please enter a valid Ingredient quantity greater than 0.");
					}
				}

                // adding in error handling - updates from feedback given
				
				Console.WriteLine("Unit"); // User is asked to enter Unit of measurement.
				string Unit = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(Unit))
				{
					Console.WriteLine("Invalid input! Unit cannot be empty, please enter a valid unit.");
				}

                // allowing user to enter calories for each ingredeint provided
                double calories;
                while (true)
                {
                    Console.WriteLine("Calories:");
                    if (double.TryParse(Console.ReadLine(), out calories) && calories > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! please enter a valid amount of calories.");
                    }
                }

                // allowing users to select a food group for each ingredient (Fruits, Vegetables, Grains, Protein and Dairy)
                string foodGroup;
                while (true)
                {
                    Console.WriteLine("Select a food group for this ingredient:");
                    for (int k = 0; k < foodGroups.Count; k++)
                    {
                        Console.WriteLine($"{k + 1}.{foodGroups[k]}");
                    }

                    // asking user to select an option from the list of foodgroups
                    Console.WriteLine("Please select a number that matches the food group of your ingredient");
                    int SelectedGroupIndex;

                    if (int.TryParse(Console.ReadLine(), out SelectedGroupIndex) && SelectedGroupIndex >= 1 && SelectedGroupIndex <= foodGroups.Count)
                    {
                        foodGroup = foodGroups[SelectedGroupIndex - 1];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number from the selection given.");
                    }
                }

                // Adding ingredients to the array list of ingredients 
                Ingredients.Add(new RecipeIngredients1 { Name = Name, Quantity = Quantity, Unit = Unit, Calories = calories, FoodGroup = foodGroup});
				originalScale.Add(new RecipeIngredients1 { Name = Name, Quantity = Quantity, Unit = Unit, Calories = calories, FoodGroup = foodGroup });
			}

			// adding in error handling - updates from feedback given
			int numberOfSteps;
			while (true)
			{
				// Promting the user to enter the number of steps required for the specific recipe entered.
				Console.WriteLine("Enter the number of steps required: ");
				if (int.TryParse(Console.ReadLine(), out numberOfSteps) && numberOfSteps > 0)
				{
					break;
				}
				else
				{
					Console.WriteLine("Invalid input! Please enter a number greater than zero.");
				}
			}
			
            // Creating a loop for details of each step to be captured.
            for (int i = 0; i < numberOfSteps; i++)
			{
				Console.WriteLine($"Enter step {i + 1}: ");
				string step = Console.ReadLine();

                // adding in error handling - updates from feedback given
				if (string.IsNullOrWhiteSpace(step))
					{
						Console.WriteLine("Recipe steps cannot be empty! Please enter a valid description for each step.");
						continue;
					}

				// Adding the recipe steps to the Steps arrayList
                Steps.Add(step);
			}

			AllRecipes[RecipeName] = this;
		}

		// Method created to display the entire recipe, after user has entered all the ingredients + steps
		public void DisplayFinishedRecipe()
		{
			// changes the colour of the Text for recipe name to Magenta
			Console.ForegroundColor = ConsoleColor.Magenta;

			// Displaying the name of the specific recipe.
			Console.WriteLine($"Recipe: {RecipeName}");

			Console.ResetColor(); // resets the colour back to the standard console colour (WHITE).

			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("Ingredients: "); // displaying the list of the ingredients - for the specific recipe.
			Console.ResetColor();

			// using for each loop - to loop + display each ingredient in the recipe.
			foreach (var ingredient in Ingredients)
			{
				// name,quantitiy,unit,calories and food group for each ingredient
				Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit} {""} [{ingredient.Calories}cals] - {ingredient.FoodGroup}");
			}

			Console.ForegroundColor = ConsoleColor.Magenta;
			// Displaying all the necessary steps included - for the specific recipe 
			Console.WriteLine("Steps: ");
			Console.ResetColor();

			for (int i = 0; i < Steps.Count; i++) // creating for loop - to loop through + display all steps + the index of array -eg) 1. Cut Onions... 2. Fry Onions.
			{
				Console.WriteLine($"{i + 1}. {Steps[i]}");
			}


            double totalCalories = 0;

			foreach (var ingredient in Ingredients)
			{
				totalCalories += ingredient.Calories;
			}

            Console.WriteLine("------------------------------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total Calories: {totalCalories}.");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");

			if (TotalCaloriesExceedsAmount(totalCalories))
			{
                Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Alert! The total calories for this recipe exceeds 300!");
				Console.ResetColor();
            }

			Console.WriteLine($"Debug:Total Calories Calculated: {totalCalories}");
			this.totalCalories = totalCalories;
        }

		// method determines if calories are over 300
		private bool TotalCaloriesExceedsAmount(double totalCalories)
		{
			return totalCalories > 300;
		}
		

		public void addRecipe(string recipeName)
		{
			AllRecipes.Add(recipeName, this);
		}


		// creating method to display list of all recipe names:
		public void displayRecipeNames()
		{
			int index = 1;
			foreach (var recipeName in AllRecipes.Keys.OrderBy(name => name))
			{
				Console.WriteLine($"{index}. {recipeName}");
				index++;
			}
		}

		// creating method to display the recipe, after user has selected it
		public void displaySelectedRecipe() 
		{ 
			if (AllRecipes.ContainsKey(RecipeName))
			{
				AllRecipes[RecipeName].DisplayFinishedRecipe();
			}
			else
			{
				Console.WriteLine("Recipe was not found in All Recipes...");
			}
		}


		// This method is created to half the RECIPES ingredients (QUANTITY) by multiplying by 0.5
		public void HalfRecipe()
		{
			// this loop is created to loop through each ingredient in the recipe and muliply it by 0.5
			foreach (var ingredient in Ingredients)
			{
		 		ingredient.Quantity *= 0.5;

				// adding in code to allow the calories to be scaled aswell
				ingredient.Calories *= 0.5;
			}
            ConvertUnits(); // updated conversion method added.

            // changes the colour of the Text for recipe name to DarkRed.
            Console.ForegroundColor = ConsoleColor.DarkRed;

			// Displaying the name of the specific recipe.
			Console.WriteLine($"Halved Recipe: {RecipeName}");

			Console.ResetColor(); // resets the colour back to the standard console colour.

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("Ingredients: "); // displaying the list of the ingredients - for the specific recipe.
			Console.ResetColor();

			// using for each loop - to loop + display each ingredient in the recipe.
			foreach (var ingredient in Ingredients)
			{
                // name,quantitiy,unit,calories and food group for each ingredient
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit} {""} [{ingredient.Calories}cals] - {ingredient.FoodGroup}");
            }

			Console.ForegroundColor = ConsoleColor.DarkRed;
			// Displaying all the necessary steps included - for the specific recipe 
			Console.WriteLine("Steps: ");
			Console.ResetColor();

			for (int i = 0; i < Steps.Count; i++) // creating for loop - to loop through + display all steps + the index of array -eg) 1. Cut Onions... 2. Fry Onions.
			{
				Console.WriteLine($"{i + 1}. {Steps[i]}");
			}

			// creating total calories for half recipe
            double totalCalories = 0;

            foreach (var ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total Calories: {totalCalories}.");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");

            if (TotalCaloriesExceedsAmount(totalCalories))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Alert! The total calories for this recipe exceeds 300!");
                Console.ResetColor();
            }
        }

		// This method is created to double the RECIPES ingredients (QUANTITY) by multiplying by 2
		public void DoubleRecipe()
		{
			// loop through and muliply each ingredient by 2
			foreach (var ingredient in Ingredients)
			{
				ingredient.Quantity *= 2;

                // adding in code to allow the calories to be scaled aswell
                ingredient.Calories *= 2;
            }

			ConvertUnits(); // updated conversion method added.

			Console.ForegroundColor = ConsoleColor.DarkRed;
			// Displaying the name of the specific recipe.
			Console.WriteLine($"Doubled Recipe: {RecipeName}");
			Console.ResetColor();

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("Ingredients: "); // displaying the list of the ingredients - for the specific recipe.
			Console.ResetColor();

			// using for each loop - to loop + display each ingredient in the recipe.
			foreach (var ingredient in Ingredients)
			{
                // name,quantitiy,unit,calories and food group for each ingredient
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit} {""} [{ingredient.Calories}cals] - {ingredient.FoodGroup}");
            }

			Console.ForegroundColor = ConsoleColor.DarkRed;
			// Displaying all the necessary steps included - for the specific recipe 
			Console.WriteLine("Steps: ");
			Console.ResetColor();

			for (int i = 0; i < Steps.Count; i++) // creating for loop - to loop through + display all steps + the index of array -eg) 1. Cut Onions... 2. Fry Onions.
			{
				Console.WriteLine($"{i + 1}. {Steps[i]}");
			}

            // creating total calories for half recipe
            double totalCalories = 0;

            foreach (var ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total Calories: {totalCalories}.");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");

            if (TotalCaloriesExceedsAmount(totalCalories))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Alert! The total calories for this recipe exceeds 300!");
                Console.ResetColor();
            }
        }

		// This method is created to triple the RECIPES ingredients (QUANTITY) by multiplying by 3
		public void TripleRecipe()
		{
			// loop through and muliply each ingredient by 3
			foreach (var ingredient in Ingredients)
			{
				ingredient.Quantity *= 3;

                // adding in code to allow the calories to be scaled aswell
                ingredient.Calories *= 3;
            }
            ConvertUnits(); // updated conversion method added.

            Console.ForegroundColor = ConsoleColor.DarkRed;
			// Displaying the name of the specific recipe.
			Console.WriteLine($"Trippled Recipe: {RecipeName}");
			Console.ResetColor();

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("Ingredients: "); // displaying the list of the ingredients - for the specific recipe.
			Console.ResetColor();

			// using for each loop - to loop + display each ingredient in the recipe.
			foreach (var ingredient in Ingredients)
			{
                // name,quantitiy,unit,calories and food group for each ingredient
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit} {""} [{ingredient.Calories}cals] - {ingredient.FoodGroup}");
            }

			Console.ForegroundColor = ConsoleColor.DarkRed;
			// Displaying all the necessary steps included - for the specific recipe 
			Console.WriteLine("Steps: ");
			Console.ResetColor();

			for (int i = 0; i < Steps.Count; i++) // creating for loop - to loop through + display all steps + the index of array -eg) 1. Cut Onions... 2. Fry Onions.
			{
				Console.WriteLine($"{i + 1}. {Steps[i]}");
			}

            // creating total calories for half recipe
            double totalCalories = 0;

            foreach (var ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total Calories: {totalCalories}.");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");

            if (TotalCaloriesExceedsAmount(totalCalories))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Alert! The total calories for this recipe exceeds 300!");
                Console.ResetColor();
            }
        }


        // method that allows user to scale recipe, by half, double or triple and allows user to reset the values aswell
        public void ScaleRecipe()
		{
			while (true)
			{
				Console.WriteLine("How would you like to scale the recipe, please choose from the options below: ");
				Console.WriteLine("1. Half Recipe");
				Console.WriteLine("2. Double Recipe");
				Console.WriteLine("3. Triple Recipe");
				Console.WriteLine("4. Reset Recipe to Original Scale.");
				Console.WriteLine("5. Return to Display menu.");


				int scalingChoice;
				if(!int.TryParse(Console.ReadLine(), out scalingChoice))
				{
					Console.WriteLine("Invalid input! please enter a valid number from the list above.");
					continue;
				}
				
				switch (scalingChoice)
				{
					case 1:
						HalfRecipe();
						break;

					case 2:
						DoubleRecipe();
						break;

					case 3:
						TripleRecipe();
						break;

					case 4:
						ResetRecipeToOriginalScale();
						break;

					case 5:
						RecipeChange(); // return user back to display menu 
						if (returnToMainMenu)
						{
							return;
						}
						break;

                    default:
						Console.WriteLine("Invalid Option, please try again and choose a number FROM 1 TO 5!");
						break;
				}
			}
		}

		// This method is created to reset the recipe data to its original scale/form, after it has been scaled by the user
		public void ResetRecipeToOriginalScale()
		{
			Ingredients.Clear(); // clears the current list of ingredients

			Ingredients.AddRange(originalScale); // adds the ingredients(QUANTITIES) from the orginalScaleList array to the current list of ingredeints

			// changes the colour of the Text for recipe name to Magenta
			Console.ForegroundColor = ConsoleColor.Magenta;

			// Displaying the name of the specific recipe.
			Console.WriteLine($"Original Recipe: {RecipeName}");

			Console.ResetColor(); // resets the colour back to the standard console colour.

			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("Ingredients: "); // displaying the list of the ingredients - for the specific recipe.
			Console.ResetColor();

			foreach (var ingredient in originalScale)
			{
                // name,quantitiy,unit,calories and food group for each ingredient
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit} {""} [{ingredient.Calories}cals] - {ingredient.FoodGroup}");
            }

			Console.ForegroundColor = ConsoleColor.Magenta;
			// Displaying all the necessary steps included - for the specific recipe 
			Console.WriteLine("Steps: ");
			Console.ResetColor();

			for (int i = 0; i < Steps.Count; i++) // creating for loop - to loop through + display all steps + the index of array -eg) 1. Cut Onions... 2. Fry Onions.
			{
				Console.WriteLine($"{i + 1}. {Steps[i]}");
			}

		}

		// This method is created to clear all the data in the application - so that the user can enter a new recipe
		public void ClearAllRecipeData()
		{
			RecipeName = ""; // clears recipe name
			Ingredients.Clear();
			Steps.Clear();
			originalScale.Clear();
		}

        // adding in updates from feedback - conversions (8tbps - 1 cup)
		private void ConvertUnits()
		{
			foreach (var ingredient in Ingredients)
			{
				if (ingredient.Unit.ToLower() == "tablespoon" && ingredient.Quantity >= 8)
				{
					ingredient.Quantity = ingredient.Quantity / 8;
					ingredient.Unit = "Cup";
				}
			}
		}

		private bool returnToMainMenu = false;

		// method to allow user to select a choice of what to do with the selected recipe name
		public void RecipeChange()
		{
			while (true) // creating list of options for the user to choose from
			{
				Console.WriteLine("What would you like to do to the selected recipe:");
				Console.WriteLine("1. Display recipe.");
                Console.WriteLine("2. Scale recipe.");
                Console.WriteLine("3. Return to Main Menu.");


				// error handling if user enters invalid input
				int choice = 0;
				if (!int.TryParse(Console.ReadLine(), out choice))
				{
					Console.WriteLine("Invalid input, please enter a number!");
					continue;
				}

				switch (choice)
				{
					case 1:
						DisplayFinishedRecipe();
						break;

					case 2:
						ScaleRecipe(); // directs user to the scaling method 
						break;

					case 3:
						returnToMainMenu = true;
						return;

					default:
						Console.WriteLine("Invalid choice, please select a valid number from the given list!");
						break;
				}

            }
		}
    }
}

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<*THE*END*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
