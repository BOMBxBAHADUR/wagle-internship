namespace SimpleCalculator
{
    // Base class for Calculator
    public class Calculator
    {
        // Method to add two numbers
        public virtual double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Method to subtract two numbers
        public virtual double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // Method to multiply two numbers
        public virtual double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        // Method to divide two numbers
        public virtual double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return 0;
            }
            return num1 / num2;
        }
    }

    // Extended Calculator class for more operations
    public class ExtendedCalculator : Calculator
    {
        // Method to calculate the remainder of two numbers (modulus)
        public override double Divide(double num1, double num2)
        {
            return base.Divide(num1, num2);
        }

        public double Modulus(double num1, double num2)
        {
            return num1 % num2;
        }
    }

    // Main class to run the calculator
    class CalculatorProgram
    {
        static void Main(string[] args)
        {
            ExtendedCalculator calculator = new ExtendedCalculator();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Simple Calculator:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Modulus");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an operation: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                {
                    exit = true;
                    continue;
                }

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                switch (choice)
                {
                    case 1:
                        result = calculator.Add(num1, num2);
                        break;
                    case 2:
                        result = calculator.Subtract(num1, num2);
                        break;
                    case 3:
                        result = calculator.Multiply(num1, num2);
                        break;
                    case 4:
                        result = calculator.Divide(num1, num2);
                        break;
                    case 5:
                        result = calculator.Modulus(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }

                Console.WriteLine("Result: " + result);
            }

            Console.WriteLine("Thank you for using the calculator. Goodbye!");
        }
    }
}
