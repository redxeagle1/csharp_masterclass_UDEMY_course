namespace HelloClass;

class Program
{
    static void Main(string[] args)
    {
            // Creating an object of the Class Car
            // Creating an instance of the Class Car
            Car audi = new("A3" , "Audi", false);
            Car bmw = new("i7", "BMW", true);


            // GETTING BRAND
            WriteLine("Brand is " +  audi.Brand);
            WriteLine("Brand is " + bmw.Brand);


            ReadKey();
    }
}
