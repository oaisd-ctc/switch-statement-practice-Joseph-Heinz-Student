using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 0:
                Console.WriteLine("Your number is Zero");
                break;
            case 1:
                Console.WriteLine("Your number is One");
                break;
            case 2:
                Console.WriteLine("Your number is Two");
                break;
            case 3:
                Console.WriteLine("Your number is Three");
                break;
            case 4:
                Console.WriteLine("Your number is Four");
                break;
            case 5:
                Console.WriteLine("Your number is Five");
                break;
            case 6:
                Console.WriteLine("Your number is Six");
                break;
            case 7:
                Console.WriteLine("Your number is Seven");
                break;
            case 8:
                Console.WriteLine("Your number is Eight");
                break;
            case 9:
                Console.WriteLine("Your number is Nine");
                break;
            case 10:
                Console.WriteLine("Your number is Ten");
                break;
            default:
                Console.WriteLine("That number is in range");
                break;
        }
    }
}