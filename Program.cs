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

                Console.WriteLine("Choose an operation to apply or (0) to exit :");
                Console.WriteLine("(0) exit");
                Console.WriteLine("(1) addition");
                Console.WriteLine("(2) subtraction");
                Console.WriteLine("(3) multiplication");
                Console.WriteLine("(4) division");
                 
                int opr=int.Parse(Console.ReadLine());
                
                
            }
        }
    }
}
