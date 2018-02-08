//Lab02
//Displaying the sum of the two numbers input from the keyboard
using System;

class Addition
{
    //Main method begins execution of C# app
    static void Main()
    {
        int number1;
        int number2;
        int sum;

        Console.Write("Enter first integer: ");
        
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: ");

        number2 = int.Parse(Console.ReadLine());

        sum = number1 + number2;

        Console.WriteLine($"Sum is {sum}");

        int x = 7;
        int y = 5;
        int z = 4;
        int answer;
        answer = (x + y) * (z + 10);

        Console.WriteLine("Hello\tWorld");
        Console.WriteLine("Hello\nWorld");
        Console.WriteLine("\"Hello World\"");
        Console.WriteLine("Hello\\World");



    }
}
