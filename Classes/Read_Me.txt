References:
Links that I used to help me with my code. (C# Code Help)
https://www.geeksforgeeks.org/c-sharp-how-to-change-foreground-color-of-text-in-console/
https://www.w3schools.com/cs/index.php
https://www.includehelp.com/dot-net/list-t-addrange-method-with-example-in-c-sharp.aspx
https://www.freecodecamp.org/news/how-to-convert-a-string-to-an-integer-in-c-sharp/
https://www.tamingtwins.com/biscoff-cheesecake/ - RECIPE TAKEN FROM THIS WEBSITE
Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming - TEXTBOOK
[Andrew Troelsen / Phillip Japikse / Apress Publishers]

*************************************************************
LINK TO GITHUB REPOSITORY:

https://github.com/mathewsthania/POEPart1_SaneleRecipeApp.git

**************************************************************

Sanele's Recipe App - POE Part 1
--------------------------------

Part one of Sanele's Recipe App is a simple standalone command line application that prompts the user and 
ouputs data, based on the option chosen.

Runnning of application
------------------------
When you run the the recipe application, it opens up and welcomes the user to the application:
"Welcome to Sanele's Recipe App!"

Features
---------
It then brings up 4 options/features that the user can choose from:
1. Enter a new Recipe.
2. Scale the Recipe.
3. Clear all data.
4. Exit Application.

Description of features
-----------------------

(IF THE USER SELECTS OPTION 1)
1. Enter a new Recipe:
   - This feature prompts the user to enter details for a single recipe.
   - The user is prompted to enter the recipe name.
     ( 'Enter Recipe Name:' );

   - The user is prompted to enter the number of ingredients for the recipe. 
     ( 'Enter the number of ingredients required:' );
     [ If the user enters 6, the ingredients name, quantity and unit of measurement, will loop 6 times for each ingredient ]


   - The user is prompted to enter the name, quantity and unit of measurement of each ingredient.
     ('Enter the details for this ingredient 1:
	 Ingredient Name: 
	 Quantity:
     Unit: ');


   - The user is prompted to enter the number of steps of the recipe.
	 ( 'Enter the number of steps required:' );
     [ If the user enters 6, it will loop 6 times for each step and for the user to input a description for each step ]
   

   - The user is prompted to enter a description of what the user should do for each step.
	 ('Enter step 1: ' );

   - This feature also displays the entire recipe and all its details after the user is done inputting all the information
     (' Recipe: 
		Ingredients:
		-
		-
		Steps:
		1. 
		2. 
	  ')
	  [ The recipe name, ingredients(name) and steps(name) are displayed and ouputted in a colour (Pink)]

-------------------------------------------------------------------------------------------------------------------------

   EXAMPLE 1: Application running for 1. Enter a new Recipe.
   --------------------------------------------------------
	
   1. Enter a new Recipe:
	
	  Enter Recipe Name: Biscoff Cheesecake
	  Enter the number of ingredients required: 6

	  Enter the details for this ingredient 1:
	  Ingredient Name: Biscoff Biscuits
	  Quantity: 200
	  Unit: g

	  Enter the details for this ingredient 2:
	  Ingredient Name: Unsalted Butter (Melted)
	  Quantity: 80
	  Unit: g

	  Enter the details for this ingredient 3:
	  Ingredient Name: Double Cream
	  Quantity: 300
	  Unit: ml

	  Enter the details for this ingredient 4:
	  Ingredient Name: Full Fat cream cheese
	  Quantity: 400
	  Unit: g

	  Enter the details for this ingredient 5:
	  Ingredient Name: Biscoff Spread
	  Quantity: 200
	  Unit: g

	  ******************************************
	  Enter the details for this ingredient 6:
	  Ingredient Name: Vanilla Essence
	  Quantity: 8
	  Unit: tablespoons
	  ***********************++++++++++++++++++++

	  * [ IF THE USER ENTERS 8 AS QUANTITY AND TABLESPOONS AS UNIT - THE APPLICATION AUTOMATICALLY CHANGES IT TO 1 CUP]
	    [ THEREFORE 8 TABLESPOONS = 1 CUP]

	  Enter the number of steps required: 7

	  Enter step 1:
	  Combine the crushed biscoff biscuits with the melted butter and press into a tin. 
	  Chill in the fridge while you make the topping.

	  Enter step 2:
	  Pour the double cream into a bowl, add the cream cheese and Biscoff spread and vanilla essence. Whisk until
	  it's very thick – almost the consistency of ice cream. Use an electric whisk if you have one.

	  Enter step 3:
	  Remove the base from the fridge and add the cheesecake mixture, smoothing the top.

	  Enter step 4:
	  Pop into the fridge for at least 3 hours (or overnight is much better if you don't need it until the next day).

	  Enter step 5:
	  When you are almost ready to serve the cheesecake, melt the Biscoff spread very gently in a pan.
	  (Don't let it get hot.)

	  Enter step 6:
	  Remove the cheesecake from the fridge and, while still in the tin, pour the melted Biscoff over the top. 
	  Smooth it out very gently with the back of a spoon, until the top is completely covered. 
	  (Take care not to touch the cheesecake mixture.) Sprinkle the remaining crushed biscuits around the edge.


	  Enter step 7:
	  Return the cheesecake to the fridge for at least a further hour if you have the time. You could cut it
	  sooner but it won't be as neat.

	  *********************************************************
	  DISPLAYED RECIPE FORMAT
	  *********************************************************

	  Recipe: Biscoff Cheesecake (Magenta Colour)

	  Ingredients: (Magenta Colour)
	  Biscoff Biscuits: 200g
	  Unsalted Butter: 80g
	  Double Cream: 300ml
	  Full Fat cream cheese: 400g
	  Biscoff Spread: 200g
	  Vanilla Essence: 1 cup *(will automatically convert and display as one cup) 

	  Steps: (Magenta Colour)
	  1. Combine the crushed biscoff biscuits with the melted butter and press into a tin. 
	  Chill in the fridge while you make the topping.
	  2. Pour the double cream into a bowl, add the cream cheese and Biscoff spread and vanilla essence. Whisk until it's very thick 
	  – almost the consistency of ice cream. Use an electric whisk if you have one
	  3. Remove the base from the fridge and add the cheesecake mixture, smoothing the top.
	  4. Pop into the fridge for at least 3 hours (or overnight is much better if you don't need it until the next day).
	  5. When you are almost ready to serve the cheesecake, melt the Biscoff spread very gently in a pan. 
	  (Don't let it get hot.)
	  6. Remove the cheesecake from the fridge and, while still in the tin, pour the melted Biscoff over the top. Smooth 
	  it out very gently with the back of a spoon, until the top is completely covered. 
	  (Take care not to touch the cheesecake mixture.) Sprinkle the remaining crushed biscuits around the edge.
	  7. Return the cheesecake to the fridge for at least a further hour if you have the time. You could cut it
	  sooner but it won't be as neat.

	  -------------------------------------------------------------------------------------------------------------------

	  1.1) After the recipe is displayed it will loop the user back to the main menu of the application, where we started off.
		   The user will be able to choose what they want to do next.


	  (IF THE USER SELECTS OPTION 2)
	  2. Scale the Recipe: 
	     
		 - If the user selects option 2 ('Scale the Recipe')
		 - The user will be asked how they would like to scale the recipe
		   (Meaning, if they would like to scale the recipe up or down)

		- The application will bring up 3 options for the user to choose from:
		[ For each scaling option it will display the entire recipe, with the updated scaled quantities ]
		[ For the scaled recipes - The recipe name, ingredients(name) and steps(name) are displayed and ouputted in a different colour (Dark Red)]

		  1. Half Recipe. (Halves the recipes ingriedients (QUANTITIES) therfore, multiplying the quantities by 0.5)
		  2. Double Recipe. (Doubles the recipes ingriedients (QUANTITIES) therfore, multiplying the quantities by 2)
		  3. Triple Recipe. (Triples the recipes ingriedients (QUANTITIES) therfore, multiplying the quantities by 3)
		  4. Reset Recipe to oringal Scale (Resets the recipe ingredients back to its original quantities - if the user chose to scale the recipe)
		  5. Return to main menu (Returns the user back to the main menu of the application - where we started off)

-------------------------------------------------------------------------------------------------------------------------

   EXAMPLE 2: Application running for 2. Scale the Recipe
   --------------------------------------------------------

   2. Scale the Recipe.

	  How would you like to scale the recipe, please choose from the options below:
 	
	  1. Half Recipe. 
	  2. Double Recipe. 
	  3. Triple Recipe. 
	  4. Reset Recipe to oringal Scale.
	  5. Return to main menu 

	  ------------------------------------------------------------------------------------------------------------------

	  (IF USER SELECTS OPTION 1)
	  1. Half Recipe.

	  *********************************************************
	  DISPLAYED RECIPE FORMAT
	  *********************************************************

	  Halved Recipe: Biscoff Cheesecake (Dark Red Colour)
	  Ingredients: (Dark Red Colour)
	  Biscoff Biscuits: 100g
	  Unsalted Butter: 40g
	  Double Cream: 150ml
	  Full Fat cream cheese: 200g
	  Biscoff Spread: 100g
	  Vanilla Essence: 4tablespoons

	  Steps: (Dark Red Colour)
	  1. Combine the crushed biscoff biscuits with the melted butter and press into a tin. 
	  Chill in the fridge while you make the topping.
	  2. Pour the double cream into a bowl, add the cream cheese and Biscoff spread and vanilla essence. Whisk until it's very thick 
	  – almost the consistency of ice cream. Use an electric whisk if you have one
	  3. Remove the base from the fridge and add the cheesecake mixture, smoothing the top.
	  4. Pop into the fridge for at least 3 hours (or overnight is much better if you don't need it until the next day).
	  5. When you are almost ready to serve the cheesecake, melt the Biscoff spread very gently in a pan. 
	  (Don't let it get hot.)
	  6. Remove the cheesecake from the fridge and, while still in the tin, pour the melted Biscoff over the top. Smooth 
	  it out very gently with the back of a spoon, until the top is completely covered. 
	  (Take care not to touch the cheesecake mixture.) Sprinkle the remaining crushed biscuits around the edge.
	  7. Return the cheesecake to the fridge for at least a further hour if you have the time. You could cut it
	  sooner but it won't be as neat.

	  ------------------------------------------------------------------------------------------------------------------

	  (IF USER SELECTS OPTION 2)
	  2. Double Recipe.

	  *********************************************************
	  DISPLAYED RECIPE FORMAT
	  *********************************************************

	  Halved Recipe: Biscoff Cheesecake (Dark Red Colour)
	  Ingredients: (Dark Red Colour)
	  Biscoff Biscuits: 400g
	  Unsalted Butter: 160g
	  Double Cream: 600ml
	  Full Fat cream cheese: 800g
	  Biscoff Spread: 400g
	  Vanilla Essence: 2cups *(16 tablespoons)

	  Steps: (Dark Red Colour)
	  1. Combine the crushed biscoff biscuits with the melted butter and press into a tin. 
	  Chill in the fridge while you make the topping.
	  2. Pour the double cream into a bowl, add the cream cheese and Biscoff spread and vanilla essence. Whisk until it's very thick 
	  – almost the consistency of ice cream. Use an electric whisk if you have one
	  3. Remove the base from the fridge and add the cheesecake mixture, smoothing the top.
	  4. Pop into the fridge for at least 3 hours (or overnight is much better if you don't need it until the next day).
	  5. When you are almost ready to serve the cheesecake, melt the Biscoff spread very gently in a pan. 
	  (Don't let it get hot.)
	  6. Remove the cheesecake from the fridge and, while still in the tin, pour the melted Biscoff over the top. Smooth 
	  it out very gently with the back of a spoon, until the top is completely covered. 
	  (Take care not to touch the cheesecake mixture.) Sprinkle the remaining crushed biscuits around the edge.
	  7. Return the cheesecake to the fridge for at least a further hour if you have the time. You could cut it
	  sooner but it won't be as neat.

	  -------------------------------------------------------------------------------------------------------------------

	  (IF USER SELECTS OPTION 3)
	  3. Triple Recipe.

	  *********************************************************
	  DISPLAYED RECIPE FORMAT
	  *********************************************************

	  Halved Recipe: Biscoff Cheesecake (Dark Red Colour)
	  Ingredients: (Dark Red Colour)
	  Biscoff Biscuits: 600g
	  Unsalted Butter: 240g
	  Double Cream: 900ml
	  Full Fat cream cheese: 1200g
	  Biscoff Spread: 600g
	  Vanilla Essence: 3cups (24 tablespoons)

	  Steps: (Dark Red Colour)
	  1. Combine the crushed biscoff biscuits with the melted butter and press into a tin. 
	  Chill in the fridge while you make the topping.
	  2. Pour the double cream into a bowl, add the cream cheese and Biscoff spread and vanilla essence. Whisk until it's very thick 
	  – almost the consistency of ice cream. Use an electric whisk if you have one
	  3. Remove the base from the fridge and add the cheesecake mixture, smoothing the top.
	  4. Pop into the fridge for at least 3 hours (or overnight is much better if you don't need it until the next day).
	  5. When you are almost ready to serve the cheesecake, melt the Biscoff spread very gently in a pan. 
	  (Don't let it get hot.)
	  6. Remove the cheesecake from the fridge and, while still in the tin, pour the melted Biscoff over the top. Smooth 
	  it out very gently with the back of a spoon, until the top is completely covered. 
	  (Take care not to touch the cheesecake mixture.) Sprinkle the remaining crushed biscuits around the edge.
	  7. Return the cheesecake to the fridge for at least a further hour if you have the time. You could cut it
	  sooner but it won't be as neat.

	  -------------------------------------------------------------------------------------------------------------------

	  (IF USER SELECTS OPTION 4)
	  4. Reset Recipe to original scale.

	  *********************************************************
	  DISPLAYED RECIPE FORMAT
	  *********************************************************

	  Recipe: Biscoff Cheesecake (Magenta Colour)

	  Ingredients: (Magenta Colour)
	  Biscoff Biscuits: 200g
	  Unsalted Butter: 80g
	  Double Cream: 300ml
	  Full Fat cream cheese: 400g
	  Biscoff Spread: 200g
	  Vanilla Essence: 1 cup *(8 tablespoons)

	  Steps: (Magenta Colour)
	  1. Combine the crushed biscoff biscuits with the melted butter and press into a tin. 
	  Chill in the fridge while you make the topping.
	  2. Pour the double cream into a bowl, add the cream cheese and Biscoff spread and vanilla essence. Whisk until it's very thick 
	  – almost the consistency of ice cream. Use an electric whisk if you have one
	  3. Remove the base from the fridge and add the cheesecake mixture, smoothing the top.
	  4. Pop into the fridge for at least 3 hours (or overnight is much better if you don't need it until the next day).
	  5. When you are almost ready to serve the cheesecake, melt the Biscoff spread very gently in a pan. 
	  (Don't let it get hot.)
	  6. Remove the cheesecake from the fridge and, while still in the tin, pour the melted Biscoff over the top. Smooth 
	  it out very gently with the back of a spoon, until the top is completely covered. 
	  (Take care not to touch the cheesecake mixture.) Sprinkle the remaining crushed biscuits around the edge.
	  7. Return the cheesecake to the fridge for at least a further hour if you have the time. You could cut it
	  sooner but it won't be as neat.

	  -------------------------------------------------------------------------------------------------------------------

	  The loop will continue... until the user selects option 5 (Return to Main Menu)

	  (IF USER SELECTS OPTION 5)
	  5. Return to Main Menu.

	  It will take the user back to the main menu and display the 4 options again:
	  1. Enter a new Recipe.
	  2. Scale the Recipe.
	  3. Clear all data.
      4. Exit Application.

	  (IF THE USER SELECTS OPTION 3 OF THE MAIN MENU)
	  [ The user will choose this option, if they want to add a new recipe, they will first have to clear data and then choose the Enter new recipe option ]
	  - It will erase all the data from the applications (including all array data)

	  - It will then bring up a confirmation message, saying that all the data has been cleared:
	    ( 'All Recipe data has been cleared successfully!' );

	  ************ The user will now be able to add a new recipe, using option 1 *************************************

	  (IF THE USER SELECTS OPTION 4) - of the Main Menu
	  4. Exit Recipe Application.

	  The application will bring up a message:
	  ( 'Exiting Recipe Application..... We hope to see you soon!' );

	  AND THE APPLICATION/ RUNNING WINDOW will close.

	  -------------------------------------------------------------------------------------------------------------------
