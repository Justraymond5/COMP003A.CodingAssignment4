namespace COMP003A.CodingAssignment4;
// Author: Raymond Gonzalez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.
class Program
{
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
                Console.WriteLine("Welcome to the Inventory Management System!");
                Console.WriteLine("Choose data storage type:");
                Console.WriteLine("We will be using the Array System type to store!");
                Console.WriteLine("Please enter '1' to proceed using  Arrays");
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
                Console.WriteLine("\n");
                Console.WriteLine("\nInventory Management System Menu:");
                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice: ");
                int inventoryChoice = int.Parse(Console.ReadLine());
                if (inventoryChoice == 1)
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
                                Console.Write("Product added successfully!");
                            
                                // (Open) Stores the product info in the arrays
                                productNames[count] = productName;
                                productQuantities[count] = productQuantity;
                                count++;
                                // (Close) Stores the product info in the arrays
                            
                                break;
                            }
                            catch (FormatException )
                            {
                                Console.WriteLine("You did something wrong!");
                            }   
                        }
                        else
                        {
                            Console.WriteLine("Backpack is full, cant add more than 10 items");
                            break;
                        }
                        
                    }
                }
                else if (inventoryChoice == 2)
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
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Please enter a valid new quantity");
                            }
                        }
                        int newQuantity = int.Parse(Console.ReadLine());
                        productQuantities[index] = newQuantity; // Update product quantity after valid find of product name
                        Console.WriteLine("Product quantity updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid product name!");
                    }
                }
                else if (inventoryChoice == 3)
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