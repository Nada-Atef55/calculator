namespace Simulation.Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Enter first number : ");
                bool checkNum1 = int.TryParse(Console.ReadLine(), out int num1);

                Console.Write("Enter second number : ");
                bool checkNum2 = int.TryParse(Console.ReadLine(), out int num2);

                if (!(checkNum1 && checkNum2))
                {
                    Console.WriteLine("invalid input");
                    break;
                }
            }
        }
    }
}
