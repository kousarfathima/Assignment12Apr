using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("-----------------");
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = ReadNumber();

            Console.WriteLine("Enter the operator (+, -, *, /, %):");
            char op = ReadOperator();

            Console.WriteLine("Enter the second number:");
            double num2 = ReadNumber();

            double result = Calculate(num1, num2, op);

            Console.WriteLine("Result: " + result);
            Console.WriteLine();

            Console.WriteLine("Do you want to perform another calculation? (Y/N)");
            string continueOption = Console.ReadLine();

            if (continueOption.ToUpper() != "Y")
                break;

            Console.Clear();
        }

        Console.WriteLine("Thank you for using the calculator!");
    }

    static double ReadNumber()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid number:");
        }
        return number;
    }

    static char ReadOperator()
    {
        char op;
        while (!char.TryParse(Console.ReadLine(), out op) || !IsValidOperator(op))
        {
            Console.WriteLine("Invalid input. Please enter a valid operator (+, -, *, /, %):");
        }
        return op;
    }

    static bool IsValidOperator(char op)
    {
        return op == '+' || op == '-' || op == '*' || op == '/' || op == '%';
    }

    static double Calculate(double num1, double num2, char op)
    {
        double result = 0.0;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Error: Division by zero is not allowed!");
                break;
            case '%':
                result = num1 % num2;
                break;
        }
        return result;
    }
}
