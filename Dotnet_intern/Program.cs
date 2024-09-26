namespace Dotnet_intern;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("x:");
        var x = int.Parse(Console.ReadLine());
        Console.Write("y:");
        var y = int.Parse(Console.ReadLine());
        // Console.Write("operation:");
        // var operation  = (Console.ReadLine());

        if (x<y)
        {
            Console.WriteLine(x+y);
        }
        else
        {
            Console.WriteLine( x-y);
        }    
    }
     
}