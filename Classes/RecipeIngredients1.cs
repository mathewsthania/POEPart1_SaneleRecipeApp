using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

/// <summary>
/// Thania Mathews
/// StID: ST10381071
/// Module: PROG6221
/// Date: 2024/03/15
/// </summary>
/// This class stores the individiual ingredient details including get and set
/// - NAME
/// - QUANTITY
/// - UNIT

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<*THE*START*OF*FILE*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

namespace SaneleRecipeApp.Classes
{
	public class RecipeIngredients1
	{
		// creating getters and setters for the ingredients
		public string Name { get; set; }
		public double Quantity { get; set; }
		public string Unit { get; set; }
		public double Calories { get; set; }
		public string FoodGroup { get; set; }
	}
}

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<*THE*END*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

