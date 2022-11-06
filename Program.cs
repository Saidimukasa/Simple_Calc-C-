// A c# calculator program using switch case    

int num1, num2, result;
Console.WriteLine("Welcome to the calculator program");
Console.WriteLine("Enter \n 1.Addition\n 2.Subtraction\n 3.Multiplication\n 4.Division");
int options=Convert.ToInt32(Console.ReadLine());

//Switch control statement
switch (options)
{
    case 1:
//         User Entry for First number
        Console.WriteLine("Enter first number");
        num1 = Convert.ToInt32(Console.ReadLine());
//         User Entry for Second number
        Console.WriteLine("Enter second number");
        num2 = Convert.ToInt32(Console.ReadLine());
        result = num1 + num2;
//         Outputing Result
        Console.WriteLine("Result is " + result);
        break;
    case 2:
        //         User Entry for First number
        Console.WriteLine("Enter first number");
        num1 = Convert.ToInt32(Console.ReadLine());
        //         User Entry for Second number
        Console.WriteLine("Enter second number");
        num2 = Convert.ToInt32(Console.ReadLine());
        result = num1 - num2;
        //         Outputing Result
        Console.WriteLine("Result is " + result);
        break;
    case 3:
        //         User Entry for First number
        Console.WriteLine("Enter first number");
        num1 = Convert.ToInt32(Console.ReadLine());
         //         User Entry for Second number
        Console.WriteLine("Enter second number");
        num2 = Convert.ToInt32(Console.ReadLine());
        result = num1 * num2;
        //         Outputing Result
        Console.WriteLine("Result is " + result);
        break;
    case 4:
         //         User Entry for First number.
        Console.WriteLine("Enter first number");
        num1 = Convert.ToInt32(Console.ReadLine());
         //         User Entry for Second number
        Console.WriteLine("Enter second number");
        num2 = Convert.ToInt32(Console.ReadLine());
        result = num1 / num2;
         //         Outputing Result
        Console.WriteLine("Result is " + result);
//         The Break statement helps us to jump out of the Case 
        break;
//         Default is used to display an Error message in case of any Wrong Entry
    default:
        Console.WriteLine("Invalid choice");
        
        break;
}

