using System;

namespace HelloClass;

internal class Customers
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? ContactNumber { get; set; }

    // default constructor
    public Customers()
    {     
        Name = "New Customer";
        Address = "Unknown";
        ContactNumber = "None";
    }

    //Custom Constructor
    public Customers(string name, string address, string contactNumber)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public Customers(string name)
    {
        Name = name;
    }

    public void SetDetails(string name, string address,string contactNumber)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }
}
