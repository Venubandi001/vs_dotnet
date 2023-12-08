// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


public class Customer
{
    protected bool _id;

    public bool ID
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }
}

public class Customer1 : Customer
{
    public static void Main(string[] args)
    {
        Customer c = new Customer();
        
        Console.WriteLine("Enter the Id Value");
        c.ID = bool.Parse(Console.ReadLine());
        Console.WriteLine("this is set ID {0}",c.ID);
    }
   
}
