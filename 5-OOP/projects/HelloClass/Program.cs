namespace HelloClass;

class Program
{
    static void Main(string[] args)
    {
        Car hundai = new("hundai","jeff");
        Car BMW = new("BMW","sini");
        WriteLine(hundai.Model);
        hundai.Model = "hundai the indi";
        WriteLine(hundai.Model);
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        BMW.Model = null ;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        WriteLine(BMW.Model);
    }
}
