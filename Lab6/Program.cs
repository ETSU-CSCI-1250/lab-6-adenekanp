// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Type in INDEX for character count, RETAIL for price, TEMP for temperature, and PRIME for prime numbers :)");
        string option = Console.ReadLine();
        Console.Clear();
        switch (option.Trim().ToUpper())
        {
            case "INDEX":
                ShowCharacter();
                break;
            case "RETAIL":
                CalcRetail();
                break;
            case "TEMP":
                Celsius();
                break;
            case "PRIME":
                PrimeNumber();
                break;
            default:
                Console.WriteLine("Something is not right, try another option.");
                break;
        }
    }
    static void ShowCharacter()
    {
        string words;
        int i;

        Console.WriteLine("Put some words here: ");
        words = Console.ReadLine();
        Console.WriteLine("What index position?");
        i = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"The character here is {words[i]}");

    }
    static void CalcRetail()
    {
        double input;
        double i;
        Console.WriteLine("Whats the retail price of the item?");
        input = Int32.Parse(Console.ReadLine());
        Console.WriteLine("How much markup (in percentage)?");
        i = Int32.Parse(Console.ReadLine());

        double price = input * i / 100;
        double total = price + input;
        Console.WriteLine($"Mark-up price is ${total}");
    }
    static void Celsius()
    {
        for (int i = 80; i <= 100; i++)
        {
            double FCConversion = (i - 32) * 5.0 / 9.0;
            Console.WriteLine($"\nFahrenheit: {i} degrees \nCelsius: {Math.Round(FCConversion, 2)} degrees \n");

        }
    }
    static void PrimeNumber()
    {
        double number;
        double prime;
        Console.WriteLine("Check any number to see if its a prime number or not: ");
        number = Int32.Parse(Console.ReadLine());

        if (number < 1)
        {
            Console.WriteLine("No can do, try again.");
        }
        else if (!(number >= 2 && number % 2 == 0))
        {
            while (!(number >= 2 && number % 2 == 0))
            {
                Console.WriteLine("Yep its prime!");
                Console.WriteLine("Try another.");
                number = Int32.Parse(Console.ReadLine());
                if (number >= 2 && number % 2 == 0)
                {
                    Console.WriteLine("Nope. This number is not a prime number");
                }
            }
        }
        else if (number >= 2 && number % 2 == 0)
        {
            Console.WriteLine("Nope. This number is not a prime number");
        }
    }
}
