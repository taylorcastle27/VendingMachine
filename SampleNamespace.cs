using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class SampleNamespace
    {
        class SampleClass
        {
            public void SampleMethod()
            {
                // This is a sample method
                Console.WriteLine("SampleMethod inside SampleNamespace");
            }
        }
    }
}
public class Person
{
    public string personName;
    public string personAge;

    // Static Field Great for default values and are initialized only once
    public static string defaultName;
    public static string defaultAge;
    // Static Constructor
    static Person()
    {
        defaultName = "Unknown";
        defaultAge = "Unknown";
    }
    // Instance Constructor
    public Person()
    {
        // Field initialization and constructor logic goes here
        personName = defaultName;
        personAge = defaultAge;
    }
    public Person(string name)
    {
        // Field initialization and constructor logic goes here
        personName = name;
        personAge = defaultAge;
    }
    public Person(string name, string age)
    {
        personName = name;
        personAge = age.ToString();
    }
}