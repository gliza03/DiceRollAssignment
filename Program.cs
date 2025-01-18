using Mission2Assign;
internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.WriteLine("How many dice rolls would you like to simulate?");
        string stringNum = Console.ReadLine();
        int number = int.Parse(stringNum);

        Class1 simulator = new Class1();

        int[] results = simulator.SimulateRolls(number);

        // Print results
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {number}.\n");

        // Print histogram
        for (int i = 2; i <= 12; i++)
        {
            // Calculate percentage and round to nearest integer
            int percentage = (int)Math.Round((double)results[i] / number * 100);
            string stars = "";

            // Add stars
            for (int j = 0; j < percentage; j++)
            {
                stars += "*";
            }

            Console.WriteLine($"{i}: {stars}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");


    }
}