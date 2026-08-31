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
    }
}
