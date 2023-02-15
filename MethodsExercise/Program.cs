namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?"); // output for name
            var name = Console.ReadLine(); // input for name
            Console.WriteLine("What is your favorite color?"); // output for color
            var color = Console.ReadLine(); //input for color
            Console.WriteLine("How old are you?"); // output for age
            var age = Console.ReadLine(); // input for age
            Console.WriteLine("Who is your favorite baseball team?"); // output for baseball team
            var team = Console.ReadLine(); // input for baseball team
            string? teamout; // creates a null variable for teamout
            if (team != "Astros")
                teamout = $"I hope the {team} lose to the Astros in the World Series.";
            else
                teamout = $"I hope the {team} win the World Series!";
            Console.WriteLine($"Hello, {name}! I'm surprised that someone who is {age} years old considers {color} to be their favorite color. Good for you. \n" +
                $"{teamout}");
        }
    }
}
