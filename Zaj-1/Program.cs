using System;

class Program
{
    static void Main()
    {
        // Deklaracja zmiennych
        int number = 10;
        float money = 99.99f;
        string text = "Hello, C#!";
        bool isLogged = true;
        char myChar = 'A';
        decimal price = 199.99m;

        string myAge = "Age: ";
        int wifeAge = 18;
        string result = myAge + wifeAge;

        int a = 5, b = 12;
        int add = a + b;
        int sub = a - b;
        int div = a / b;
        int mul = a * b;
        int mod = a % b;

        bool isTrue = true;
        bool isFalse = false;
        bool isReallyTrue = true;

        bool and = isTrue && isFalse;
        bool or = isTrue || isReallyTrue;
        bool negative = !isFalse;

        string aStr = "Ala ";
        string bStr = "ma ";
        string cStr = "kota.";
        string resultStr = aStr + bStr + cStr;

        int n1 = 10, n2 = 20;
        if (n1 > n2)
        {
            Console.WriteLine($"{n1} jest większe od {n2}");
        }
        else if (n1 < n2)
        {
            Console.WriteLine($"{n2} jest większe od {n1}");
        }
        else
        {
            Console.WriteLine($"{n1} jest równe {n2}");
        }

        // Pętla for
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("C#");
        }

        // Pętla while
        int count = 0;
        while (count < 10)
        {
            Console.WriteLine("C#");
            count++;
        }

        // Sprawdzenie parzystości liczb od 0 do n
        int n = 10;
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} - Parzysta");
            }
            else
            {
                Console.WriteLine($"{i} - Nieparzysta");
            }
        }

        // Wypisanie schematu gwiazdek
        int starsN = 5;
        for (int i = 1; i <= starsN; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        // Wyświetlenie wartości zmiennych w konsoli
        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Money: {money}");
        Console.WriteLine($"Text: {text}");
        Console.WriteLine($"Is Logged: {isLogged}");
        Console.WriteLine($"My Char: {myChar}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Result: {result}");
        Console.WriteLine($"Add: {add}");
        Console.WriteLine($"Sub: {sub}");
        Console.WriteLine($"Div: {div}");
        Console.WriteLine($"Mul: {mul}");
        Console.WriteLine($"Mod: {mod}");
        Console.WriteLine($"AND: {and}");
        Console.WriteLine($"OR: {or}");
        Console.WriteLine($"Negative: {negative}");
        Console.WriteLine($"Result String: {resultStr}");
        /*C# automatycznie konwertuje wifeAge na string, aby umożliwić połączenie wartości.
        Operacja myAge + wifeAge wykona konkatenację (połączenie) wartości zamiast dodawania liczb, ponieważ myAge jest typu string, a wifeAge typu int. Wynik będzie: "Age: 18"
        Podobnie konkatenacja trzech stringów aStr, bStr i cStr daje "Ala ma kota."*/

    }
}
