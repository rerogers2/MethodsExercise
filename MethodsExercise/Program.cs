using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Markup;
using System.Xml.Schema;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            story(); // writes a story based on inputs

            // finding the hypotenuse of a right triangle given two sides 
            Console.WriteLine("Let's find the hypotenuse of a right triangle.\n");
            Console.Write("Side length one: "); // output for side one
            var num1 = Convert.ToDouble(Console.ReadLine()); // input for side one
            Console.Write("Side length two: "); // output for side two
            var num2 = Convert.ToDouble(Console.ReadLine()); // input for side two

            Console.WriteLine($"\nThe hypotenuse of your right triangle with side lengths {num1} and {num2} is {hyp(num1, num2)}.\n"); // finds the hypotenuse of a right triangle
            Console.WriteLine($"The longest hypotenuse length those two sides could create must be less than {maxlength(num1, num2)}.\n"); // finds the max possible length
            Console.WriteLine($"The shortest hypotenuse length those two sides could create must be larger than {minlength(num1, num2)}.\n"); // finds the min possible length
            Console.WriteLine($"The sum of 5 and 12 is {sum(5, 12)}.\n");

            Console.Write($"The sum of multiple digits for this example is: {sums(2, 3, 4, 12)}.\n");
        }

        public static void story()
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
                teamout = $"I hope the {team} miss the playoffs. GO ASTROS!";
            else
                teamout = $"I hope the {team} win the World Series!";
            Console.WriteLine($"Hello, {name}! I'm surprised that someone who is {age} years old considers {color} to be their favorite color. Good for you. \n" +
                $"{teamout}\n");
        }

        public static double hyp(double num1, double num2) // calculates the hypotenuse
        {
            double total = Math.Round(Math.Sqrt(Math.Pow(num1, 2) + Math.Pow(num2, 2)),2);
            return total;
        }

        public static double maxlength(double num1, double num2) // calculates the max length of the hypotenuse
        {
            double total = Math.Round((num1 + num2),2);
            return total;
        }

        public static double minlength(double num1, double num2)  // calculates the min length of the hypotenuse
        {
            double total = Math.Round(Math.Abs(num1 - num2),2);
            return total;
        }

        public static int sum(int a, int b) // sums two numbers
        {
            return a + b; 
        }

        public static int sums(params int[] ints)
        {
            int sum = 0;
            foreach (int value in ints)
            {
                sum += value;
            }
            return sum;
        }
    }
}
