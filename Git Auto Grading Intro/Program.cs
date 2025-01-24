namespace StudentProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Welcome to the calculator project, complete the methods

            // Call the methods here. (Done)
            int Addition = Add(2, 3);
            Console.WriteLine("The result of adding 2 and 3 is: " + Addition);
        
            int Subtraction = Subtract(4, 2);
            System.Console.WriteLine($"The result of the subtraction is: {Subtraction}");

            int multiplication = Multiply(4, 2);
            System.Console.WriteLine($"The Result of the Multiplication: {multiplication}");

            decimal division = Divide(8, 4);
            System.Console.WriteLine($"The result of the division is: {division}");
        
        }

        // Methods Here (Done)
        public static int Add(int a, int b)
        {
            // Code (Done)
            return a + b; // Placeholder
        }
        public static int Subtract(int a, int b)
        {
            // Code (Done)
            return a - b; // Placeholder
        }
        public static int Multiply(int a, int b)
        {
            // Code (Done)
            return a * b; // Placeholder
        }
        public static decimal Divide(int a, int b)
        {
            // Code (Done)
            return a / b; // Placeholder
        }
    }
}
