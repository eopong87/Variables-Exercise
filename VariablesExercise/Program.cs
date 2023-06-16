namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string childsname; //Declaration syntax
            childsname = "JON JON"; // Initialized--- assigning a value
            int childsage = 5; // Declaring and intializing
            char firstinitial = 'J';
            bool ishungry = true;
            double childsweight = 60.9;
            decimal childsheight = 42.5m;
            Console.WriteLine($"hello my childs name is {childsname} and he is {firstinitial}, and he is {childsage} years old.");
            Console.WriteLine($"He weighs {childsweight} pounds and he is {childsheight}inches tall.");
            Console.WriteLine($" He is {ishungry} he is always hungry.");
        }
    }
}
