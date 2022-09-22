class Program
{
    static void Main(String[] args)
    {

        Console.WriteLine("Do you want to count? (y/n)");
        char count = Convert.ToChar(Console.ReadLine());

        if (count == 'y')
        {
            while (count == 'y')
            {
                display();
                Console.WriteLine("Enter action (1...4) : ");
                double list = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter first number :");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number :");
                double number2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Result :");

                switch (list)
                {
                    case 1:
                        addition(number1, number2);
                        break;
                    case 2:
                        substraction(number1, number2);
                        break;
                    case 3:
                        multiplication(number1, number2);
                        break;
                    case 4:
                        division(number1, number2);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nDo you want to count? (y/n)");
                count = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Exit Program");

        }
        else if (count == 'n')
        {
            Console.WriteLine("Exit program");
        }



    }

    static void display()
    {
        Console.WriteLine("\nSimple Calculator\n");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Substraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)\n");
    }

    static void addition(double number1, double number2)
    {
        Console.WriteLine(number1 + number2);
    }

    static void substraction(double number1, double number2)
    {
        Console.WriteLine(number1 - number2);
    }

    static void multiplication(double number1, double number2)
    {
        Console.WriteLine(number1 * number2);
    }

    static void division(double number1, double number2)
    {
        Console.WriteLine(number1 / number2);
    }
}