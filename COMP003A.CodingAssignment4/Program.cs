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
        
        
        //Intro
        Console.WriteLine("Welcome to the Inventory Management System!");
        Console.WriteLine("Choose data storage type:");
        Console.WriteLine("1. Arrays");
        Console.WriteLine("2. Lists");
        Console.Write("Enter your choice: ");
        int theirChoice =int.Parse(Console.ReadLine());
        //End Intro
        
        while (true) 
        //Start of Main Loop
        {
            if (theirChoice == 1)
            {
                Console.WriteLine("\nInventory Management System Menu:");
                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int inventoryChoice =int.Parse(Console.ReadLine());

                if (inventoryChoice == 1)
                {
                    Console.Write("Enter product name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Enter product quantity: ");
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
                    Console.Write("\nEnter product name: ");
                    string updateNameProduct = Console.ReadLine();
                    int index = Array.IndexOf(productNames, updateNameProduct, 0, count); // Find product index
                    // (Close) Finds the name product to update
                    
                    // (Open) When it finds the name
                    if (index != -1) 
                    {
                        Console.Write("Enter new quantity: ");
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
                    Console.WriteLine("\nTotal Products: ");
                    Console.WriteLine("Total Quantity: ");
                    Console.WriteLine("Average Quantity: ");
                    
                }
                if (inventoryChoice == 4)
                {
                    Console.WriteLine("Exiting! Goodbye!"); 
                    break;
                }
            }
            
            
            
            
            
            
            
            
            
        }
        //End of Main Loop
            
    }
}