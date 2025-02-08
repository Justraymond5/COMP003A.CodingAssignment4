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
        string[] productNames = new string[10];
        int[] productQuantities = new int[10];
        int count = 0; // Keeps track of how many products are in the array
        //End Storage Arrays
        //Storage Lists
        List<string> productName2 = new List<string>(); 
        List<int> productQuantities2 = new List<int>();
        //Close Storage Lists
        
        
        //Intro
        Console.WriteLine("Welcome to the Inventory Management System!");
        Console.WriteLine("Choose data storage type:");
        Console.WriteLine("1. Arrays");
        Console.WriteLine("2. Lists");
        while (true)
        {
            try
            {
                Console.Write("Enter your choice: ");
                break;
                        
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid, TRY A NUMBER");
            }   
        }
        
        int theirChoice =int.Parse(Console.ReadLine());
        //End Intro
        
        while (true) 
        //Start of Main Loop
        {
            //Start of Array
            if (theirChoice == 1)
            {
                
                Console.WriteLine("\nInventory Management System Menu:");
                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
                
                while (true)
                {
                    try
                    {
                        Console.Write("Enter your choice: ");
                        break;
                        
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                }
                int inventoryChoice =int.Parse(Console.ReadLine());

                if (inventoryChoice == 1)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter product name: ");
                            break;
                        
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid name");
                        }   
                    }
                    string productName = Console.ReadLine();
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter product quantity: ");
                            break;
                        
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid quantity");
                        }   
                    }
                    int productQuantity =int.Parse(Console.ReadLine());
                    Console.Write("Product added successfully!");
                    Console.Write("\n");
                    
                    // (Open) Stores the product info in the arrays
                    productNames[count] = productName;
                    productQuantities[count] = productQuantity;
                    count++;
                    // (Close) Stores the product info in the arrays
                    
                }

                else if (inventoryChoice == 2)
                {
                    Console.WriteLine("Update Product Quantity");
                    // (open) Finds the name product to update
                    while (true)
                    {
                        try
                        {
                            Console.Write("\nEnter product name: ");
                            break;
                        
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid product name");
                        }   
                    }
   
                    string updateNameProduct = Console.ReadLine();
                    int index = Array.IndexOf(productNames, updateNameProduct, 0, count); // Finding the prodcut via the array index
                    // (Close) Finds the name product to update
                    
                    // (Open) When it finds the name
                    if (index != -1) 
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
                        productQuantities[index] = newQuantity; // Update product quantity
                        Console.WriteLine("Product quantity updated successfully!");
                    }
                    // (Closed) When it finds the name --> replaces quantity
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
                    double average = sum / productQuantities.Length;
                    // Calculation for average
                    Console.WriteLine($"\nTotal Products: {count} ");
                    Console.WriteLine($"Total Quantity: {totalQuantity} ");
                    Console.WriteLine($"Average Quantity: {average:F2}");
                    
                }
                if (inventoryChoice == 4)
                {
                    Console.WriteLine("Exiting! Goodbye!"); 
                    break;
                }
            }
            //End of Array
            //Start of List
            if (theirChoice == 2)
            {
                Console.WriteLine("\nInventory Management System Menu:");
                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
                
                while (true)
                {
                    try
                    {
                        Console.Write("Enter product name: ");
                        break;
                        
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid name");
                    }   
                }
                int inventoryChoice =int.Parse(Console.ReadLine());

                if (inventoryChoice == 1)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter product quantity: ");
                            break;
                        
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid quantity");
                        }   
                    }
                    string productName = Console.ReadLine();
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter product quantity: ");
                            break;
                        
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid quantity");
                        }   
                    }
                    int productQuantity =int.Parse(Console.ReadLine());
                    Console.Write("Product added successfully!");
                    Console.Write("\n");
                    
                    // (Open) Stores the product info in the arrays
                    productName2.Add(productName);
                    productQuantities2.Add(productQuantity);
              
                    // (Close) Stores the product info in the arrays
                    
                }

                else if (inventoryChoice == 2)
                {
                    Console.WriteLine("Update Product Quantity");
                    // (open) Finds the name product to update
                    while (true)
                    {
                        try
                        {
                            Console.Write("\nEnter product name: ");
                            break;
                        
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid product name");
                        }   
                    }
                    string updateNameProduct = Console.ReadLine();
                    int index = productName2.IndexOf(updateNameProduct);
                    // (Close) Finds the name product to update
                    
                    // (Open) When it finds the name
                    if (index != -1) 
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
                        productQuantities2[index] = newQuantity; // Update product quantity
                        Console.WriteLine("Product quantity updated successfully!");
                    }
                    // (Closed) When it finds the name --> replaces quantity
                }
                else if (inventoryChoice == 3)
                {
                    Console.Write("\nInventory Summary: ");
                    Console.WriteLine("\n ");
                    int totalQuantity = 0;
                    for (int i = 0; i < productName2.Count; i++) // WriteLine's the stored products
                    {
                        Console.WriteLine($"- {productName2[i]}: {productQuantities2[i]}");
                        totalQuantity += productQuantities2[i];
                    }
                    
                    double sum = 0;
                    for (int i = 0; i < productQuantities.Length; i++)
                    {
                        sum += productQuantities[i];
                    }
                    double average = sum / productQuantities2.Count;
                    // Calculation for average
                    Console.WriteLine($"\nTotal Products: {productName2.Count} ");
                    Console.WriteLine($"Total Quantity: {totalQuantity} ");
                    Console.WriteLine($"Average Quantity: {average:F2}");
                    
                }
                if (inventoryChoice == 4)
                {
                    Console.WriteLine("Exiting! Goodbye!"); 
                    break;
                }
            }
            //End of List
        }
        //End of Main Loop
            
    }
}
//Notes of Asignment
//For the arrays I used an integer 'count' variable to track how many items have been added. Ensure the count does not exceed the array's size.
//Hint Arrays: Use Array.IndexOf() to find the index of the product name.
// Hint  Lists: Use .IndexOf() to find the index of the product name.
//For list it was .Add()