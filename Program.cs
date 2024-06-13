using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        Console.SetWindowSize(100, 100);

        Console.WriteLine("\t\t\t\t Welcome to my first Console application");
        Console.WriteLine("W S, D, A tugmalari orqali * ni siljiting " +
                            "  chiqish uchun Escape " +
                            "Counter dagidek hammasi ");
        Console.WriteLine(Environment.NewLine);

        int balandlik = 25;
        int kenglik = 50;
        // bizga kerak bo'ladigan maydonni belgilab chizib olamiz.
        try
        {
            for (int height = 0; height < balandlik; height++)
            {
                for (int width = 0; width < kenglik; width++)
                {
                    if (height == 0)
                    {
                        Console.Write("` ");
                    }
                    else if (width == 0 && height != 0)
                    {
                        Console.Write("` ");
                    }
                    if (height == balandlik - 1 && width != 0)
                    {
                        Console.Write("` ");
                    }

                    else if (height != 0 && height != balandlik - 1 && width != 0 && width != kenglik - 1)
                    {
                        Console.Write("  ");
                    }
                    else if (width == kenglik - 1 && height != 0 && height != balandlik - 1)
                    {
                        Console.Write("` ");
                    }

                }
                Console.WriteLine();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter a numeric value.");
        }

        int x = 2;  // Boshlang'ich x koordinatasi 
        int y = 5; // Boshlang'ich y koordinatasi 
        
        Console.CursorVisible = false; // Kursorni yashirish

        while (true)
        {
            Console.SetCursorPosition(x, y); // kursorni qayerdan boshlashimiz
            Console.WriteLine("*"); // berilgan positionda chiqaradi.

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);//bu false qiymatda qaytaradigan tip.
                                                           //so it was true nothing will return

            Console.SetCursorPosition(x, y);
            Console.Write(" ");

            switch (keyInfo.Key)
            {
                case ConsoleKey.A:
                    if (x > 2) x--; // Chapga harakat
                    break;
                case ConsoleKey.D:
                    if (x < 2 * kenglik - 4) x++; // O'ngga harakat
                    break;
                case ConsoleKey.W:
                    if (y > 5) y--; // Yuqoriga harakat
                    break;
                case ConsoleKey.S:
                    if (y < balandlik + 2) y++; // Pastga harakat
                    break;
                case ConsoleKey.Escape:
                    Console.Clear(); // ekranni tozalab tashlaydi.
                    Console.CursorVisible = true; // kursorni ko'rinadigan qiladi.
                    return; //  dasturga qaytish.

            }
        }       
    }
}
