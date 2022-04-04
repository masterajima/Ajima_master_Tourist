***********************************Create Grocery Store App Using Blazor***************************************************************************************
Create a new branch on the repository you used in assignment 01, and call the new branch Assignment 02
Clear out the contents of the branch, so there are no files from assignment 1 in the branch.
Be sure to make your commits to github branch often, so you don't lose any work along the way. There should be at least 3 useful commits made on your new github branch specifically for this assignment. 
In this assignment, you'll be creating an interface for a grocery store to help track food items in their associated isles.
Create a new Blazor Server Application called FirstNameLastNameGroceryApp, where you replace FirstName and LastName accordingly with your own name.

****************************************create component*****************************************************************************************************
Add a file to your app called FoodItem.cs
In FoodItem file, define a class by the same name. Give it a quantity number property, and 3 more properties you believe help define food you would find in a grocery store.
Add another file to your app called GroceryIsle.cs
In your GroceryIsle file, define a class by the same name and define it to contain a List of FoodItems, an isle name, and an isle number (this isle number value will be unique for each isle you define).
Add a razor component to the app, such that can also act as a page, and call it GroceryStore.
Add a link to the GroceryStore Page in your app's built in side navigation.
In your GroceryStore Component, add a List of GroceryIsle's.
Add 3 items to your GroceryIsle List that contain information about at least 3 different isles you would find at a grocery store, each of which should include at least 2 FoodItem's. Make sure each food item has a quantity above 0 but below 20 set.
Display the GroceryIsle's List values on the page using a loop. Below each GroceryIsle's properties, display each of the corresponding FoodItem Lists using a loop inside of each GroceryIsles loop. (i.e. the whole thing should be drawn dynamically, there should be no hard coded outputs of individual GroceryIsle's or individual FoodItem's, they should all be dynamically drawn, no matter how many you have of each.)
For each FoodItem outputted, add two buttons next to the quantity that can increase and decrease the value of the quantity of each FoodItem by 1 when clicked. (i.e. One button will increase the quantity, and one button will decrease the quantity).

*****************************************Add click event on Page*******************************************************************************************************
Do not allow the quantity of any FoodItem to go below 0 or above 20 when a button is clicked.
At the top of the page, above all the GroceryIsle's outputted values, Add a header tag (ex. h1, h2, etc.) that says add Food Item to an isle.
Add input boxes below the header for each property of a food item, a well as an input box for an isle number. The user will be using these input boxes to add new FoodItem's to an isle.
Below the inputs add a button that, when clicked, will create a FoodItem based on the info inputted and add it to the GroceryIsle of the isle number specified in the input. 
Once you've added the FoodItem to the right GroceryIsle, clear the input boxes values, and the new FoodItem should automatically appear under the right column in your list.
Add the GroceryStore component to the bottom of your Index page, but do not display the header, input fields and the button that would be used to add a new FoodItem at the top of the GroceryStore component when it is on your Index page. (i.e. those inputs and button should only appear if you access the GroceryStore component directly as a page).
