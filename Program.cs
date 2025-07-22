// Remove or comment out one of the duplicate VendingMachine class definitions to resolve CS0101.
// The following is the existing VendingMachine class. 
// Ensure there is only one definition of VendingMachine in your project.

class VendingMachine
{
    // Class fields
    public int Count = 30;
    public int Capacity = 100;
    public int MoneyCollected = 300;
    public string Manufacturer = "VendorCo";

    // Class methods
    public void Display() // Changed to public
    {
        Console.WriteLine("I am the display method for displaying the menu");
    }
    void DispenseProduct()
    {
        Console.WriteLine("I am the DispenseProducts method for dispensing products");
    }
    void Refill()
    {
        Console.WriteLine("I am the Refill method for refilling the vending machine");
    }
    public void Buy(string product)
    {
        Console.WriteLine("You bought: ", product);
    }
}

//class Demo // Class containing the main method
//{
//    public static void Main(string[] args)
//    {
//        var vendingMachine = new VendingMachine(); // Create an instance of the VendingMachine class
//        // Calling the members of the VendingMachine class
//        // Console.WriteLine("The capacity of the vending machine is: {0}", vendingMachine.Capacity);
//        //vendingMachine.Display(); // Call the Display method\
//        vendingMachine.Buy("Chocolate Bar"); // Call the Buy method with a product name
//    }
//}

class CalculatorDemo
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();   // Create an instance of the Calculator class
        double x = 10;
        double y = 20;
        double z = 5;

        int a = 12;
        int b = 4;

        Console.WriteLine(calculator.Product(x, y)); // Calls the method with two doubles
        Console.WriteLine(calculator.Product(x, y, z)); // Calls the method with three doubles
        Console.WriteLine(calculator.Product(a, b)); // Calls the method with two integers
    }
}