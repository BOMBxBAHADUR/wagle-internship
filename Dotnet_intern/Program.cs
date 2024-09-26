namespace Dotnet_intern;

class Program
{
    static void Main(string[] args)
    {
        // Friend 1 asks for Friend 2's name
        Console.Write("Friend 1: Hi! What's your name? ");
        string friend2Name = Console.ReadLine();

        // Friend 1 reacts to the name
        Console.WriteLine($"Friend 1: Wow, {friend2Name} is a nice name!");

        // Friend 1 asks to be friends
        Console.WriteLine("Friend 1: Will you be my friend?");
        string friend2Response = Console.ReadLine();

        // Respond to Friend 2's answer
        if (friend2Response.ToLower() == "yes")
        {
            Console.WriteLine("Friend 1: Awesome! We’re friends now!");
        }
        else
        {
            Console.WriteLine("Friend 1: That's okay, maybe another time.");
        }

        // Ending the conversation
        Console.WriteLine("Friend 1: It was nice talking to you!");
    }
    
}