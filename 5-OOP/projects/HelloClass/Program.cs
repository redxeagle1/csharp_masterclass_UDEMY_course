namespace HelloClass;

class Program
{
    static void Main(string[] args)
    {
            // Creating an object of the Class Car
            // Creating an instance of the Class Car
            Car myAudi = new("A3" , "Audi", false);
            myAudi.Drive();
            Customers myCustomer =new();
            myCustomer.SetDetails("hamada","Betengan street 3","05577910");
            WriteLine($"MyCustomer is : {myCustomer.Name} and he lives in {myCustomer.Address} and his number is {myCustomer.ContactNumber}");

            ReadKey();
    }
}
