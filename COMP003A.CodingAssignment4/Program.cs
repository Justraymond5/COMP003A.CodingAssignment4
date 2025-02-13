namespace COMP003A.CodingAssignment4;
// Author: Raymond Gonzalez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.
class Program
{
    //Method for storing main into
    /// <summary>
    /// This is just a short into about what type of system will be used to show it when called
    /// </summary>
    static void Into()
    {
        Console.WriteLine("Welcome to the Inventory Management System!");
        Console.WriteLine("We will be using the Array System type to store!");
        Console.WriteLine("Please enter '1' to proceed using  Arrays");  
    }
    // Method for storing menu
    /// <summary>
    /// Storing the menu in a method to show it when called
    /// </summary>
    static void Menu()
    {
        Console.WriteLine("\n");
        Console.WriteLine("\nInventory Management System Menu:");
        Console.WriteLine("1. Add a Product");
        Console.WriteLine("2. Update Product Quantity");
        Console.WriteLine("3. View Inventory Summary");
        Console.WriteLine("4. Exit");
        Console.Write("\nEnter your choice: ");  
    }
    //Method for Part 1: Add
    //Notes:Syntax; type of variable, string. parameter (), needs to have value of the variables for each type of variable, ex string and int
    /// <summary>
    /// Used a string method to store text, more spescifually input text from the user and save it into an array
    /// </summary>
    /// <param name="productNames">Stores names of the product</param>
    /// <param name="productQuantities">Stores quantities of the product</param>
    /// <param name="count">Keeps track of how many items</param>
    /// <returns>A weak catch all, telling the user they did something wrong so they would have to try again</returns>
    static string addingInfo( ref string[] productNames, ref int[] productQuantities, ref int count)
    {
        while (true) //Cycle through inventroyChoice 1 until everything is good to move on
        {
            if (count < 10) //Check if they break the bagpack
            {
                try
                {
                    Console.Write("Enter product name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Enter product quantity: ");
                    int productQuantity = int.Parse(Console.ReadLine());
                    //Console.Write("Product added successfully!");
                    
                            
                    // (Open) Stores the product info in the arrays
                    productNames[count] = productName;
                    productQuantities[count] = productQuantity;
                    count++;
                    // (Close) Stores the product info in the arrays
                    return "Product added successfully!";        
                    
                }
                    catch (FormatException )
                    {
                        //Console.WriteLine("You did something wrong!");
                        return "You did something wrong!";
                    }   
            }
            else
            {
                //Console.WriteLine("Backpack is full, cant add more than 10 items");
                //break;
                return "Backpack is full, cant add more than 10 items";
            }
                        
        }
    }
    //Notes: Same syntax as above
    /// <summary>
    /// Allowing to change the valuses saved in the array
    /// </summary>
    /// <param name="productNames"> Name of product</param>
    /// <param name="productQuantities">Number of quantites</param>
    /// <param name="count">keeps track of number of products and quantites </param>
    /// <returns> Error message to try again or a good job message to then push the menu again</returns>
    static string Update( ref string[] productNames, ref int[] productQuantities, ref int count)
    {
        Console.WriteLine("Update Product Quantity");
        Console.Write("\nEnter product name: ");
        string updateNameProduct = Console.ReadLine();
        int index = Array.IndexOf(productNames, updateNameProduct, 0, count); //Cyles through the array "string folder" in search for updateNameProduct starting from 0 
                    
        if (index != -1) //if it finds the product, good if not bad so it loops back
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter new quantity: ");
                    int newQuantity = int.Parse(Console.ReadLine());
                    productQuantities[index] = newQuantity; // Update product quantity after valid find of product name
                    //Console.WriteLine("Product quantity updated successfully!");
                    return "Product updated successfully!";
                   
                }
                catch (FormatException)
                {
                    //Console.WriteLine("Please enter a valid new quantity");
                    return "Please enter a valid new quantity";
                }
            }
        }
        else
        {
            
            //Console.WriteLine("Please enter a valid product name!");
            return "Please enter a valid product name!";
        }  
    }
    /// <summary>
    /// A void method to avoid a need for return, used to display a calculation
    /// </summary>
    /// <param name="productNames">Store productNames </param>
    /// <param name="productQuantities">Store productQuantities</param>
    /// <param name="count">Keep track of number of items (names and quantites)</param>
    static void inventoryMath( ref string[] productNames, ref int[] productQuantities, ref int count)
    {
        Console.Write("\nInventory Summary: ");
        Console.WriteLine("\n ");
        int totalQuantity = 0;
        for (int i = 0; i < count; i++) // WriteLine's the stored products
        {
            Console.WriteLine($"- {productNames[i]}: {productQuantities[i]}");
            totalQuantity += productQuantities[i];
        }

        double sum = 0;
        for (int i = 0; i < productQuantities.Length; i++)
        {
            sum += productQuantities[i];
        }
        // Calculation for average
        double average = (count > 0) ? sum / count : 0;
        Console.WriteLine($"\nTotal Products: {count} ");
        Console.WriteLine($"Total Quantity: {totalQuantity} ");
        Console.WriteLine($"Average Quantity: {average:F2}");  
        
    }
    static void Main(string[] args)
    {
        //Storage Arrays
        string[] productNames = new string[10];//Just makes ten strings variables saved under a 'folder' called productNames
        int[] productQuantities = new int[10];//Same as above but integer
        int count = 0; // Keeps track of how many products are in the array
        //End Storage Arrays

        /*//Storage Lists
        List<string> productName2 = new List<string>();
        List<int> productQuantities2 = new List<int>();
        //Close Storage Lists*/

        //Intro
        int theirChoice = 0;
        while (true)
        {

            try
            {
                Into();
                //Console.WriteLine("2. Lists");
                Console.Write("Enter your choice: ");
                theirChoice = int.Parse(Console.ReadLine());

                if (theirChoice == 1 ) //||theirChoice ==2
                {
                    break; //User did everything chill
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                    Console.WriteLine("\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nEnter a number in the correct format!");
                continue;
            }
        }

        while (true)
        {
         //Start of Array
            if (theirChoice == 1)
            {
                Menu();
                int inventoryChoice = int.Parse(Console.ReadLine());
                if (inventoryChoice == 1)
                {
                    //Syntax: Remove the variable types
                    Console.WriteLine(addingInfo(ref productNames, ref productQuantities, ref count));
                }
                else if (inventoryChoice == 2)
                {
                    //Syntax: Same as above
                    Console.WriteLine(Update( ref productNames, ref productQuantities, ref count));
                    
                }
                else if (inventoryChoice == 3)
                {
                    //Syntax: Same as above
                    inventoryMath(ref productNames, ref productQuantities, ref count);
                    
                }
                else if (inventoryChoice == 4)
                {
                    Console.WriteLine("Exiting! Goodbye!");
                    break;
                }
            }

            
            
            
            
            
            
            
            //Start of Main Loop
            // Starting code incase I need to do both array and list
            /*if (theirChoice == 2)
            {
                Console.WriteLine("\nInventory Management System Menu:");
                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
            }   */
        }
    }

    
}    
//Notes of Assignment

//For the arrays I used an integer 'count' variable to track how many items have been added. Ensure the count does not exceed the array's size.
//Hint Arrays: Use Array.IndexOf() to find the index of the product name.
// Hint  Lists: Use .IndexOf() to find the index of the product name.
//For list it was .Add()

//When using Methods ->> it saves strings of code in a differnt world
//When you need to use it just call for its name
//The name is the name of the new folder which is your method name
//If it has peramiters have the name of the peramiters aswell.
// A paramerter is just like the name of the action that methond will run
// The ref key is just collecting the value, but it needs to be called too with that same ref