// A c# calculator program using switch case    

int num1, num2, result;
Console.WriteLine("Welcome to the calculator program");
Console.WriteLine("Enter \n 1.Addition\n 2.Subtraction\n 3.Multiplication\n 4.Division");
int options=Convert.ToInt32(Console.ReadLine());

switch (options)
{
    case 1:
        Console.WriteLine("Enter first number");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        num2 = Convert.ToInt32(Console.ReadLine());
        result = num1 + num2;
        Console.WriteLine("Result is " + result);
        break;
    case 2:
        Console.WriteLine("Enter first number");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        num2 = Convert.ToInt32(Console.ReadLine());
        result = num1 - num2;
        Console.WriteLine("Result is " + result);
        break;
    case 3:
        Console.WriteLine("Enter first number");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        num2 = Convert.ToInt32(Console.ReadLine());
        result = num1 * num2;
        Console.WriteLine("Result is " + result);
        break;
    case 4:
        Console.WriteLine("Enter first number");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        num2 = Convert.ToInt32(Console.ReadLine());
        result = num1 / num2;
        Console.WriteLine("Result is " + result);
        break;
    default:
        Console.WriteLine("Invalid choice");
        
        break;
}

