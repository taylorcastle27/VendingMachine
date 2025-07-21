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

class Demo // Class containing the main method
{
    public static void Main(string[] args)
    {
        var vendingMachine = new VendingMachine(); // Create an instance of the VendingMachine class
        // Calling the members of the VendingMachine class
        // Console.WriteLine("The capacity of the vending machine is: {0}", vendingMachine.Capacity);
        //vendingMachine.Display(); // Call the Display method\
        vendingMachine.Buy("Chocolate Bar"); // Call the Buy method with a product name
    }
}