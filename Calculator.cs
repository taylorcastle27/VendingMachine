using System;

public class Calculator
{
    public Calculator()
    {
    }

    public double Product(double x, double y)
    {
        return x * y;
    }

    // Overload the function to handle three arguments
    public double Product(double x, double y, double z)
    {
        return x * y * z;
    }

    // Overloading the function to handle integers
    public int Product(int x, int y)
    {
        return x * y;
    }
}



